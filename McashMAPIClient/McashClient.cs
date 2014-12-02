using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Web;
using System.Net;

namespace Mcash
{
    public class McashError: Exception {
        public McashError(string message) : base(message) {}
        public McashError(string message, Exception innerException) : base(message, innerException) {}
    }

    public class McashResponseError : McashError
    {
        public McashResponseError(HttpStatusCode statusCode, string description = "")
            : base(String.Format("{0:d} {0}: {1}", statusCode, description))
        {
        }
    }

    public class MapiAuthenticator : IAuthenticator
    {
        readonly string _merchantId, _userId, _authKey, _testbedToken, _authMethod;
        public MapiAuthenticator(string merchantId, string userId, string authKey, string authMethod, string testbedToken = null)
        {
            _merchantId = merchantId;
            _userId = userId;
            _authKey = authKey;
            _authMethod = authMethod;
            _testbedToken = testbedToken;
        }

        public void Authenticate(IRestClient client, IRestRequest request)
        {
            request.AddHeader("X-Mcash-Merchant", _merchantId);
            request.AddHeader("X-Mcash-User", _userId);
            if (_testbedToken != null) request.AddHeader("X-Testbed-Token", _testbedToken);
            if (_authMethod == "SECRET") request.AddHeader("Authorization", String.Format("SECRET {0}", _authKey));
            else throw new ArgumentException("Invalid auth method " + _authMethod);
        }
    }


    public class McashClient
    {
        readonly string _merchantId, _userId, _baseUri, _posId;
        readonly IAuthenticator _authenticator;

        public McashClient(string baseUri, string merchantId, string userId, string posId, string authKey, string authMethod, string testbedToken = null)
        {
            
            _merchantId = merchantId;
            _userId = userId;
            _baseUri = baseUri;
            _posId = posId;
            _authenticator = new MapiAuthenticator(_merchantId, _userId, authKey, authMethod, testbedToken);
        }

        public IRestResponse<T> Execute<T>(RestRequest request, Object body = null,  HttpStatusCode? status=null, bool absoluteUri = false) where T : new()
        {
            RestClient client;
            if (absoluteUri) {
                client = new RestClient();
            } else {
                client = new RestClient(_baseUri);
            }
            client.AddHandler("application/vnd.mcash.api.merchant.v1+json", new RestSharp.Deserializers.JsonDeserializer());
            client.Authenticator = _authenticator;

            if (body != null)
            {
                request.RequestFormat = DataFormat.Json;
                request.AddBody(body);
            }
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Accept", "application/vnd.mcash.api.merchant.v1+json");
            var response = client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                const string message = "Error retrieving response.  Check inner details for more info.";
                throw new McashError(message, response.ErrorException);
            }
            if (status == null && (int) response.StatusCode / 100 != 2 || status != null && response.StatusCode != status)
            {
                throw new McashResponseError(response.StatusCode);
            }
            return response;
        }

        public void Execute(RestRequest request, Object body = null, HttpStatusCode? status=null, bool absoluteUri = false)
        {
            Execute<object>(request, body, status, absoluteUri);
        }

        public Resources.Merchant GetMerchantInfo()
        {
            var request = new RestRequest(String.Format("merchant/{0}/", _merchantId), Method.GET);
            request.RootElement = "Merchant";
            return Execute<Resources.Merchant>(request).Data;
        }

        public string CreatePaymentRequest(
            string pos_tid, string action, string customer, string currency, string amount,
            string additionalAmount = null, int expiresIn = 300, string callbackUri = null)
        {
            var pr = new Resources.CreatePaymentRequest
            {
                pos_id = _posId,
                pos_tid = pos_tid,
                action = action,
                customer = customer,
                currency = currency,
                amount = amount,
                additional_amount = additionalAmount,
                expires_in = expiresIn,
                callback_uri = callbackUri
            };
            var request = new RestRequest("/payment_request/", Method.POST);
            return Execute<Resources.ResourceId>(request, pr).Data.id;
        }

        public Resources.PaymentRequestDetails GetPaymentRequestDetails(string tid)
        {
            var request = new RestRequest(String.Format("/payment_request/{0}/", tid));
            return Execute<Resources.PaymentRequestDetails>(request).Data;
        }

        public Resources.PaymentRequestOutcome GetPaymentRequestOutcome(string tid)
        {
            var request = new RestRequest(String.Format("/payment_request/{0}/outcome/", tid));
            return Execute<Resources.PaymentRequestOutcome>(request).Data;
        }

        public void DoPaymentRequestAction(string tid, string action, string callbackUri = null)
        {
            var pr = new Resources.UpdatePaymentRequest
            {
                action = action,
                callback_uri = callbackUri
            };
            var request = new RestRequest(String.Format("/payment_request/{0}/", tid), Method.PUT);
            Execute(request, pr);
        }
        
        public void AbortPaymentRequest(string tid, string callbackUri = null)
        {
            DoPaymentRequestAction(tid, "abort", callbackUri);
        }

        public void CapturePaymentRequest(string tid, string callbackUri = null)
        {
            DoPaymentRequestAction(tid, "capture", callbackUri);
        }

        public string CreateShortlink(string callback_uri = null, string serial_number = null)
        {
            dynamic sl = new
            {
                callback_uri = callback_uri,
                serial_number = serial_number
            };
            var request = new RestRequest("/shortlink/", Method.POST);
            return Execute<Resources.ResourceId>(request, sl).Data.id;
        }

        public string GetLastScan(string shortlinkId, int ttl = 60) {
            var request = new RestRequest(String.Format("/shortlink/{0}/last_scan/?ttl={1}", shortlinkId, ttl));
            var response = Execute<Resources.ShortlinkScan>(request);
            if (response.StatusCode == HttpStatusCode.NoContent) {
                return null;
            } else {
                return response.Data.id;
            }
        }

        public Resources.Ledger GetLedger(string ledgerId = "default")
        {
            var request = new RestRequest(String.Format("/ledger/{0}/", ledgerId));
            var response = Execute<Resources.Ledger>(request);
            return response.Data;
        }

        public void CloseReport(string reportUri, string callbackUri=null) 
        {
            dynamic reqData = new {callback_uri = callbackUri};
            var request = new RestRequest(reportUri, Method.PUT);
            Execute(request, reqData, absoluteUri: true);
        }
    }
}