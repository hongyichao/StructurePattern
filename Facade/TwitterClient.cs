﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class TwitterClient
    {
        public List<Tweet> getRecentTweets(String accessToken)
        {
            Console.WriteLine("Getting recent tweets");

            return new List<Tweet>();
        }
    }
}
