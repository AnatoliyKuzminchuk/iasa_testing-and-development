using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EPAMtests
{

    public class Token
    {
        static public string token = "Bearer " + "sl.An-_vGjmussfAiBcJq7rmdAgWieTrNf0CorkdxD_si-TweES7zV0itlQcDo2p21fbQb2JUg5_Pdhi0TZ3UZ_YM_ZAiCBDez9UWtldM6USKkfljwSpTvFd7ycb_tkrlB9zTnsaZ53N1k";
    }
    public class TestUpload
    {
        [Test]
        public void _1UploadTest()
        {
            var client = new RestClient("https://content.dropboxapi.com/2/files/upload");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Dropbox-API-Arg", "{\"mode\":\"add\",\"autorename\":true,\"mute\":false,\"path\":\"/exam\"}");
            request.AddHeader("Content-Type", "application/octet-stream");
            request.AddHeader("Authorization", Token.token);
            request.AddParameter("application/octet-stream", "<file contents here>", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Assert.AreEqual(true, response.IsSuccessful);
            Assert.AreEqual(true, response.Content.Contains("exam"));
        }
        [Test]
        public void _2GetMetaDataTest()
        {
            var client = new RestClient("https://api.dropboxapi.com/2/files/get_metadata");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", Token.token);
            request.AddParameter("application/json", "{\n\t\"path\": \"/exam\"\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Assert.AreEqual(true, response.IsSuccessful);
            Assert.AreEqual(true, response.Content.Contains("file"));
        }
        [Test]
        public void _3DeleteTest()
        {
            var client = new RestClient("https://api.dropboxapi.com/2/files/delete");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", Token.token);
            request.AddParameter("application/json", "{\r\n\t\"path\":\"/exam\"\r\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Assert.AreEqual(true, response.IsSuccessful);
            Assert.AreEqual(true, response.Content.Contains("exam"));
        }
    }

}
