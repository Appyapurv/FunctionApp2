//using jci.be.glas.azure.storage.interfaces.Queue;
//using jci.be.glas.azure.storage.Queue;
//using Microsoft.WindowsAzure.Storage;
//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace just.For.practice
//{
//    public class NestedDictionary
//    {
//        private readonly StorageQueue<AlertQueueModel> _alertStorageQueue;
//        public NestedDictionary()
//        {

//            var alertStorageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=statsqaservices;AccountKey=c30ORgSd9DGTpZ98d54N8hWi1dfpE23JbikDutfnfaVMDeK6rTRHE29FbiRaIQTjfUNDf7tEmlCTdel6wMJYDA==;EndpointSuffix=core.windows.net");
//            _alertStorageQueue = new StorageQueue<AlertQueueModel>(alertStorageAccount, "alertQueue");
//            Task.Run(async () => await _alertStorageQueue.Initialize());
//        }
//        public static void Main(string[] args)
//        {
//            NestedDictionary ns = new NestedDictionary();
//            ns.SendMessageToQueue().Wait();

//            Console.ReadLine();


//            //    var dictionary = new Dictionary<string, Dictionary<ulong, string>>();
//            //    LinkedList<ulong> linkedlist = new LinkedList<ulong>();
//            //    dictionary.Select(o => o.Value.Select(n => o.Key + "->>" + n.Key + "," + n.Value)).ToList().ForEach(Console.WriteLine);


//            //    foreach (var key in dictionary.Keys)
//            //    {
//            //        var values = dictionary[key];
//            //        foreach (var key2 in values.Keys)
//            //        {

//            //            linkedlist.AddFirst(key2);
//            //        }
//            //    }
//        }
//        public async Task SendMessageToQueue()
//        {
//            try
//            {
//                var alertQueueModel = new AlertQueueModel
//                {
//                    DeviceId = "a0-cc-2b-f3-56-88",
//                    ChangedProperties = new List<Tuple<string, object>>()
//                };
//                Tuple<string, object> record = new Tuple<string, object>("CurrentTemp", 550.0);

//                alertQueueModel.ChangedProperties.Add(record);
//                var json = JsonConvert.SerializeObject(alertQueueModel);
//                await SendAlertToQueue(alertQueueModel);
//            }
//            catch (Exception)
//            {

//                throw;
//            }


//        }

//        public async Task SendAlertToQueue(AlertQueueModel alertQueueModel)
//        {
//            try
//            {
//                await _alertStorageQueue.AddMessage(alertQueueModel);
//            }
//            catch (Exception)
//            {

//                throw;
//            }
            
//        }

//        public class AlertQueueModel : IStorageQueueMessage
//        {
//            public string DeviceId { get; set; }
//            public List<Tuple<string, object>> ChangedProperties { get; set; }
//            public string Id { get; set; }
//            public string PopReceipt { get; set; }
//            public int DequeueCount { get; set; }
//        }

//        //   IEnumerable & List:
//        //  List is derived from Ienumerable //ICollection<T>, IEnumerable<T>, IEnumerable, IList<T>, IReadOnlyCollection<T>, IReadOnlyList<T>, ICollection, IList
//        //enumerbale you can use for example where you want to update data at client side. but list you can update anywhere. it is much faster as compare to list.
//        // you can use indexing in list but not possible to have on Enumerable

//        //allOffset.SelectMany(n => n.Value.Select(o => n.Key+"->>"+o.Key+","+ o.Value))
//        // .ToList()
//        // .ForEach(Console.WriteLine);
//    }
//}
