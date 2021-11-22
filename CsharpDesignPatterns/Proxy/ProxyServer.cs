using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Proxy
{
    public class ProxyServer : ITwitter
    {
        // the proxy server has to mimic the real server
        // usually the proxy server inmplement same interface with real service
        // and also has instance of realtime object
        private RealTimeTweets _tweets;
        private string _twitterHandle;

        // one of teh main purpose of proxy : do access control
        private string _password;

        public ProxyServer(string twitterHandle, string password)
        {
            _twitterHandle = twitterHandle;
            _password = password;
        }

        // since you are not allowed to modify the real service (it's usually third party lib)
        // you can mimic the real service by implement same interface
        // but insert the logic you need in the method
        // e.g. logging, caching, access control
        public void DisplayTweets()
        {
            if (_password == "Pass123")
            {
                // lazy loading, fetch the tweets only if they are null
                // something like singleton pattern
                // to let the real server less pressed
                if (_tweets == null)
                {
                    _tweets = new RealTimeTweets(_twitterHandle);
                }

                _tweets.DisplayTweets();
            }
            else 
            { 
                Console.WriteLine("Permission error: Unauthorized");
            }
        }
    }
}
