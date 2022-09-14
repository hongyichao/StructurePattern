// See https://aka.ms/new-console-template for more information
using Facade;

Console.WriteLine("Hello, World!");

TweetApi tweetApi = new TweetApi();


var outcome = tweetApi.GetRecentTweets();