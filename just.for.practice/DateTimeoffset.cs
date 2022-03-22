using Microsoft.Azure.Devices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace just.For.practice
{
    public class DateTimeoffset
    {
        public static ServiceClient serviceClient;
        public static string connectionString = "HostName=stats-qa-iothub.azure-devices.net;SharedAccessKeyName=iot_hub_sap_read_write_service;SharedAccessKey=CQV6JAzWamc21phcV6gU3bDwxxhgKXProwv9427nkT4=";
        public void Main(String[] args)
        {
            //serviceClient = ServiceClient.CreateFromConnectionString(connectionString);
            //SendMessageTodDevice().Wait();

            DateTimeoffset ss = new DateTimeoffset();
            GetDaysFromSchedule("[4,[60,480,1080,1320],[700,620,700,620]],[4,[360,480,1080,1320],[700,620,700,620]],[4,[360,480,1080,1320],[700,620,700,620]],[4,[360,480,1080,1320],[700,620,700,620]],[4,[360,480,1080,1320],[700,620,700,620]],[4,[360,480,1080,1320],[700,620,700,620]],[4,[360,480,1080,1320],[700,620,700,620]]");
        }
        private async static Task SendMessageTodDevice()
        {
            string data = @"{""messageType"":""heartbeat"",""deviceModel"":0,""heartbeat"":1579504995}""";

            var message = new Message(Encoding.ASCII.GetBytes(data));
            await serviceClient.SendAsync("c4-be-84-99-00-dd", message);
        }


        public static List<Day> GetDaysFromSchedule(string schedule)
        {
            //Due to expected structure of the following, the data will need to be parsed as 
            //phase&minpastmidnight and temp SetPoints per day, so it will need to be parsed correctly
            //"[4,[360,480,1080,1320],[600,600,600,600]],[3,[360,480,1080],[600,600,600]],..."
            double timeOffset = -14400.0;
            var week = schedule.
                Trim().
                TrimStart('[').
                TrimEnd(']').
                Split("],[");
            var days = week.Select(x => x.Replace("]", "").Replace("[", "").Split(",")).ToArray();
            var listOfDays = new List<Day>();
            for (var index = 0; index < days.Length; index += 2)
            {
                var phaseAndTime = days[index];
                var temperatureSetPoints = days[index + 1];

                var phase = int.Parse(phaseAndTime.First());
                var minPastMidnight = phaseAndTime.Skip(1).ToArray();
                var events = temperatureSetPoints.Select((t, currentEventIndex) =>
                    new ScheduleEvent
                    {
                        //Hour = hour(minPastMidnight[currentEventIndex], timeOffset),
                        //Hour = hour(minPastMidnight[currentEventIndex]),
                        Hour = int.Parse(minPastMidnight[currentEventIndex]),
                        Temp = double.Parse(t) / 10.0
                    }).ToList();

                listOfDays.Add(new Day
                {
                    Phases = phase,
                    Events = events
                });
            }

            return listOfDays;
        }


        private static int hour(string value, double timeOffset)
        {
            TimeSpan hourFromMinute = TimeSpan.FromMinutes(int.Parse(value));
            DateTime time = DateTime.Today + hourFromMinute;

            time = time.AddSeconds(timeOffset);
            return (time.Hour * 60) + time.Minute;
        }

    }

    public class ScheduleEvent
    {

        [JsonProperty(PropertyName = "hour")]
        public int? Hour { get; set; }
        [JsonProperty(PropertyName = "temp")]
        public double? Temp { get; set; }
    }
    public class Day
    {
        [JsonProperty(PropertyName = "phases")]
        public int? Phases { get; set; }
        [JsonProperty(PropertyName = "events")]
        public List<ScheduleEvent> Events { get; set; }
    }
}
