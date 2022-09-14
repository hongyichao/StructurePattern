using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class TweetApi
    {
        public List<Tweet> GetRecentTweets() 
        {
            var authService = new AuthService();

            var accessToken = authService.GetAuthToken();
            var twitterClient = new TwitterClient();
            return twitterClient.getRecentTweets(accessToken);
        }
    }
}
