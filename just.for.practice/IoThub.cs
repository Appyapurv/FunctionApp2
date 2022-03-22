//using Microsoft.Azure.Devices;
//using System;
//using System.Text;
//using System.Threading.Tasks;

//namespace just.For.practice
//{
//    public class IoThub
//    {
//        public static ServiceClient serviceClient;
//        public static string connectionString = "HostName=stats-qa-iothub.azure-devices.net;SharedAccessKeyName=iot_hub_sap_read_write_service;SharedAccessKey=CQV6JAzWamc21phcV6gU3bDwxxhgKXProwv9427nkT4=";


//        public void Main(String[] args)
//        {
//            try
//            {
//                serviceClient = ServiceClient.CreateFromConnectionString(connectionString);
//                SendMessageTodDevice().Wait();
//            }
//            catch (Exception)
//            {

//                throw;
//            }

//        }
//        private async static Task SendMessageTodDevice()
//        {
//            //   string data = @"{""messageType"":""heartbeat"",""deviceModel"":3,""heartbeat"":1579504995}""";
//            string data = @"{""body"":{""messageType"":""heartbeat"",""deviceModel"":3,""heartbeat"":1579504995},""applicationProperties"":{""deviceModel"":3,""device-Id"":""a0-cc-2b-d9-7a-2c"",""messageType"": ""heartbeat""}}";
//            var message = new Message(Encoding.ASCII.GetBytes(data));
//            await serviceClient.SendAsync("a0-cc-2b-d9-7a-2c", message);
//        }
//    }
//}
