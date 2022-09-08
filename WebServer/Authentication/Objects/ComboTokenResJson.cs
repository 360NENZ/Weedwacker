namespace Weedwacker.WebServer.Authentication.Objects
{
	public class ComboTokenResJson
	{
		public string message;
		public int retcode;
		public LoginData data = new LoginData();

		public class LoginData
		{
			public int account_type = 1;
			public bool heartbeat;
			public string combo_id;
			public string combo_token;
			public string open_id;
			public string data = "{\"guest\":false}";
			public string? fatigue_remind = null; // ?
		}
	}
}
