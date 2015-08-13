using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Jailbreak.Model;
using Newtonsoft.Json;


namespace Jailbreak
{
	public class Auth0LoginService
	{
		public Auth0LoginService ()
		{
		}

		public async Task<Auth0User.RootObject> GetAuth0UserAsync()
		{
			//above was <Beer[]>
			var client = new System.Net.Http.HttpClient();
			var requestMessage = new HttpRequestMessage()
			{
				RequestUri = new Uri("https://adotob.auth0.com/authorize?response_type=token&scope=openid&client_id=prt0oxC0CEIB0r9dImcKtx4pCupRJk55&redirect_uri=https://adotob.auth0.com/mobile&connection=untappd"),
				Method = HttpMethod.Get,
			};

			//requestMessage.Headers.Add("Ocp-Apim-Trace", "true");
			//requestMessage.Headers.Add("Ocp-Apim-Subscription-Key", "dfda3434dd624baaa88f7e6fada83524");

			var response = await client.SendAsync(requestMessage);
			var authResultJson = "{\"beers\":" + response.Content.ReadAsStringAsync().Result + "}";
			var rootobject = JsonConvert.DeserializeObject<Auth0User.RootObject>(authResultJson);
			//var rootobject = JsonConvert.DeserializeObject<List<RootBeers>>(beerJson);
			//List<Beer> rootobject = (Beer)Newtonsoft.Json.JsonConvert.DeserializeObject(beerJson, typeof(Beer));


			return rootobject;


		}
	}
}

