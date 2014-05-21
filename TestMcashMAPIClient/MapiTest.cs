using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mcash;


namespace TestMcashMAPIClient
{

    [TestClass]
    public class MapiTest
    {
        McashClient client = new McashClient(
            Settings.Default.baseUri, Settings.Default.merchantId, Settings.Default.merchantUserId, "1", Settings.Default.merchantSecret, "SECRET",
            Settings.Default.testbedToken);

        [TestMethod]
        public void TestGetMerchantInfo()
        {
            var merchant = client.GetMerchantInfo();
            Assert.AreEqual(Settings.Default.merchantId, merchant.id);
        }

        [TestMethod]
        public void TestCreatePaymentRequest()
        {
            var pr = client.CreatePaymentRequest(Guid.NewGuid().ToString(), "SALE", "cs-alice", "NOK", "100.00", "0.00");
        }
    }
}
