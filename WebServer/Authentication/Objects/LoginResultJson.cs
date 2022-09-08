namespace Weedwacker.WebServer.Authentication.Objects
{
	public class LoginResultJson
	{
		public string message;
		public int retcode;
		public VerifyData data = new VerifyData();

        public class VerifyData
		{
			public VerifyAccountData account = new VerifyAccountData();
			public bool device_grant_required = false;
			public string realname_operation = "NONE";
			public bool realperson_required = false;
			public bool safe_mobile_required = false;
		}

		public class VerifyAccountData
		{
			public string uid;
			public string name = "";
			public string email = "";
			public string mobile = "";
			public string is_email_verify = "0";
			public string realname = "";
			public string identity_card = "";
			public string token;
			public string safe_mobile = "";
			public string facebook_name = "";
			public string twitter_name = "";
			public string game_center_name = "";
			public string google_name = "";
			public string apple_name = "";
			public string sony_name = "";
			public string tap_name = "";
			public string country = "US";
			public string reactivate_ticket = "";
			public string area_code = "**";
			public string device_grant_ticket = "";
		}
	}
}
