using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            RestClient restClient = new RestClient("https://U4VMCMPMCSIT02.aus.amer.dell.com/PMCCoreService/api/getPreferencebyemail");

            //Creating Json object
            JObject jObjectbody = new JObject();
            jObjectbody.Add("Email", "Kalpashree.21@gmail.com");
          

            RestRequest restRequest = new RestRequest("/getPreferencebyemail", Method.POST);

            //Adding Json body as parameter to the post request
            restRequest.AddParameter("application/json", jObjectbody, ParameterType.RequestBody);
            restRequest.AddHeader("x-dell-identity-restriction-api-key", "d4837f29-c934-48c8-908b-928ebeef86b0");
            restRequest.AddHeader("x-dell-identity-key", "urn:test");
            restRequest.AddHeader("Content-Type", "application/json");



            var restResponse = restClient.Execute(restRequest);

            JObject responseobj = JObject.Parse(restResponse.Content);


            //Assert.AreEqual("OPERATION_SUCCESS ", restRequest.Content, " Post failed ");
        }
    }
}