using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class AuthService
    {
        private OAuth oauth;

        public AuthService() 
        {
            oauth = new OAuth();
        }

        public string GetAuthToken() 
        {
            var requestToken = oauth.requestToken("appKey", "secret");
            var accessToken = oauth.getAccessToken(requestToken);

            return accessToken;
        }
    }
}
