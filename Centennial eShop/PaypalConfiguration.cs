using PayPal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce
{
    public class PaypalConfiguration
    {
        public readonly static string clientId;
        public readonly static string clientSecret;


        static PaypalConfiguration()
        {
            var config = getconfig();
            clientId = "Abw0quvbRtD2C-LKzrOtzcFw5xN6RpG681ctnvuQcRNgLHeJhAIoSne-ZhEL8Q3nk1kILDD0-nVR05eH";
            clientSecret = "ECq_0EYsKliU9rCfnh0AKE-FtENSUig6AkHr0Kv2EeFKULtKLg2mQxsTM4jhz5SfT3f0DjNofPJVtx7N";
        }

        private static Dictionary<string, string> getconfig()
        {
            return PayPal.Api.ConfigManager.Instance.GetProperties();
        }

        private static string GetAccessToken()
        {
            string accessToken = new OAuthTokenCredential(clientId, clientSecret, getconfig()).GetAccessToken();
            return accessToken;
        }
        public static APIContext GetAPIContext()
        {
            APIContext apicontext = new APIContext(GetAccessToken());
            apicontext.Config = getconfig();
            return apicontext;
        }
    }
}