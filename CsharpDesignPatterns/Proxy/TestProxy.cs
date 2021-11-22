using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.Proxy
{
    public static class TestProxy
    {
        public static void ProxyMain() {
            ITwitter tweet1 = new ProxyServer("@BillGates", "Pass123");
            ITwitter tweet2 = new ProxyServer("@Antony", "Pass1234");

            tweet1.DisplayTweets();
            tweet2.DisplayTweets();
        }
    }
}
