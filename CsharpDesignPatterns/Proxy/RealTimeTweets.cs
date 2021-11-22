using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Proxy
{
    public class RealTimeTweets : ITwitter
    {
        private string _twitterHandle;

        public RealTimeTweets(string twiiterHandle)
        {
            _twitterHandle = twiiterHandle;
        }

        public void DisplayTweets()
        {
            Console.WriteLine($"Display tweets for {_twitterHandle}");
        }
    }
}
