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
	public class Auth0User
	{

		public class Identity
		{
			public string access_token { get; set; }
			public string provider { get; set; }
			public int user_id { get; set; }
			public string connection { get; set; }
			public bool isSocial { get; set; }
		}

		public class RootObject
		{
			public string family_name { get; set; }
			public string given_name { get; set; }
			public string nickname { get; set; }
			public string email { get; set; }
			public string picture { get; set; }
			public string updated_at { get; set; }
			public string user_id { get; set; }
			public string name { get; set; }
			public List<Identity> identities { get; set; }
			public string created_at { get; set; }
			public string last_ip { get; set; }
			public string last_login { get; set; }
			public int logins_count { get; set; }
		}

	}
}

