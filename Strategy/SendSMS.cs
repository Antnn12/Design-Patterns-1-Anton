using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Strategy
{
    class SendSMS : IMessage
    {
        public void Send(string message)
        {
            Console.WriteLine($"sending \"{message}\" as a sms");
        }
    }
}
