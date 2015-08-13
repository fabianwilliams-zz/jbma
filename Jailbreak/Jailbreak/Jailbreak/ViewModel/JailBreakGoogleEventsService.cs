using System;
using System.Net;
using System.Net.Http;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Jailbreak.Model;

namespace Jailbreak.ViewModel
{
   public class JailBreakGoogleEventsService
    {
        public JailBreakGoogleEventsService()
        {
        }
        public async Task<JBEvent.RootObject> GetJBEventsAsync()
        {
            var client = new System.Net.Http.HttpClient();
            var requestMessage = new HttpRequestMessage()
            {
                RequestUri = new Uri("https://www.googleapis.com/calendar/v3/calendars/q1k3ll0bdkis2ceef447rthocs@group.calendar.google.com/events?key=AIzaSyAHLnznypEgj3IAWmDe04XCBpSqgKhikP4"),
                Method = HttpMethod.Get,
            };

            var response = await client.SendAsync(requestMessage);
            var eventJson = response.Content.ReadAsStringAsync().Result;
            var rootobject = JsonConvert.DeserializeObject<JBEvent.RootObject>(eventJson);

            return rootobject;



        }

        public async Task<JBEvent.RootObject> GetJBFoodTrucksAsync()
        {
            var client = new System.Net.Http.HttpClient();
            var requestMessage = new HttpRequestMessage()
            {
                RequestUri = new Uri("https://www.googleapis.com/calendar/v3/calendars/1kb2s3mt7vnlfr3i0kp0lcv0ro@group.calendar.google.com/events?key=AIzaSyAHLnznypEgj3IAWmDe04XCBpSqgKhikP4"),
                Method = HttpMethod.Get,
            };

            var response = await client.SendAsync(requestMessage);
            var eventJson = response.Content.ReadAsStringAsync().Result;
            var rootobject = JsonConvert.DeserializeObject<JBEvent.RootObject>(eventJson);

            return rootobject;



        }

    }
}
