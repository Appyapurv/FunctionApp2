//using System;
//using System.Collections.Generic;
//using System.Net.Http;
//using System.Text;
//using Newtonsoft.Json.Linq;
//using RestSharp;

//namespace just.For.practice
//{
//    public class snew
//    {
//        public static void Main(string[] args)
//        {

//            var client = new RestClient("https://partner-api-qa-integration.ehub-qa.net/oauth/token");
//            var request = new RestRequest(Method.POST);
//            request.AddHeader("cache-control", "no-cache");
//            request.AddHeader("content-type", "application/x-www-form-urlencoded");
//            request.AddParameter("application/x-www-form-urlencoded", "grant_type=client_credentials&scope=all&client_id=" + "644" + "&client_secret=" + "ZXACbePg1eKe9F", ParameterType.RequestBody);
//            IRestResponse response = client.Execute(request);



//            if (!response.IsSuccessful)
//            {
//                //throw new Exception(JsonConvert.SerializeObject(new RequestError
//                //{
//                //    Error = Unauthorized.Title,
//                //    Message = response.ToString(),
//                //    ResponseCode = Unauthorized.Code
//                //}));
//            }



//            dynamic resp = JObject.Parse(response.Content);
//            String token = resp.access_token;



//            var httpclient= new HttpClient();
//            var keyValues = new List<KeyValuePair<string, string>>
//            {
//                new KeyValuePair<string, string>("grant_type", "client_credentials")
//            };
//            var authTokenContent = new FormUrlEncodedContent(keyValues);



//            var authTokenRequest = new HttpRequestMessage()
//            {
//                RequestUri = new Uri("https://partner-api-qa-integration.ehub-qa.net/oauth/token"),
//                Method = HttpMethod.Post
//            };



//            var base64AuthKey = new UTF8Encoding().GetBytes("644" + ":" + "ZXACbePg1eKe9F");
//            authTokenRequest.Headers.Add("Authorization", $"Basic {Convert.ToBase64String(base64AuthKey)}");
//            authTokenRequest.Content = authTokenContent;



//            using (var httpClient = new HttpClient())
//            {
//                var authResult =  httpclient.SendAsync(authTokenRequest).Result;
//                var authResponse = authResult.Content.ReadAsStringAsync();



//                if (!authResult.IsSuccessStatusCode)
//                {
//                    //throw new Exception(JsonConvert.SerializeObject(new RequestError
//                    //{
//                    //    Error = Unauthorized.Title,
//                    //    Message = authResponse.Result.ToString(),
//                    //    ResponseCode = Unauthorized.Code
//                    //}));
//                }


//            }


//        }
//    }
//}
