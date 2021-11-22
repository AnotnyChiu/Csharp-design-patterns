using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.BasicConcepts
{
    public interface IEmail
    {
        void SendMail();
    }

    class OutlookEmail : IEmail 
    {
        public void SendMail() 
        {
            Console.WriteLine("Send mail by Outlook");
        }
    }

    class GoogleEmail : IEmail
    {
        public void SendMail()
        {
            Console.WriteLine("Send mail by Google");
        }
    }
}
