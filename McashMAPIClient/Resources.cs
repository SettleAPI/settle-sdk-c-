using System;
namespace Mcash.Resources
{
    public class ResourceId
    {
        public string id { get; set; }
    }


    public class Merchant
    {
        public string id {get; set; }
        public string jurisdiction { get; set; }
        public string organization_id { get; set; }
        public string business_name { get; set; }
        public string mcc { get; set; }
        public string netmask { get; set; }
        public Location location { get; set; }
    }

    public class UpdatePaymentRequest {
        public string ledger { get; set; }
        public string callback_uri { get; set; }
        public string action { get; set; }
    }

    public class CreatePaymentRequest
    {
        
        public string ledger { get; set; }
        public string callback_uri { get; set; }
        public string customer { get; set; }
        public string currency { get; set; }
        public string amount { get; set; }
        public string additional_amount { get; set; }
        public bool additional_edit { get; set; }
        public bool allow_credit { get; set; }
        public string pos_id { get; set; }
        public string pos_tid { get; set; }
        public string text { get; set; }
        public string action { get; set; }
        public int expires_in { get; set; }
    }

    public class PaymentRequestDetails : CreatePaymentRequest
    {
        public string id { get; set; }
    }

    public class PaymentRequestOutcome
    {
        public string currency { get; set; }
        public string amount { get; set; }
        public string additional_amount  { get; set; }
        public string auth_amount  { get; set; }
        public string auth_additional_amount { get; set; }
        // TODO: List for captures
        public string status { get; set; }
        public string status_code { get; set; }
        public string customer { get; set; }
        public DateTime date_modified { get; set; }
        public DateTime date_expires { get; set; }
        public string credit { get; set; }
        public string interchange_fee { get; set; }
        public string transaction_fee { get; set; }
        public string report_id { get; set; }
        public string report_uri { get; set; }
        public string ledger { get; set; }
        public string attachment_uri { get; set; }
        public string pos_id { get; set; }
        public string pos_tid { get; set; }
        public string tid { get; set; }
    }

    public class Location
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
        public float accuracy { get; set; }
    }

    public class NoopResource
    {

    }
}