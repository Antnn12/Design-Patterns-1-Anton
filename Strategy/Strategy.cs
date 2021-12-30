using Design_Patterns_Assignment.Strategy;
using System;

namespace Design_Patterns_Assignment
{
    internal class Strategy1
    {

        internal static void Run()
        {
            SendSMS sendSMS = new();
            SendEmail sendEmail = new();
            SendFacebookMessage sendFacebookMessage = new();
            MessageHandler messageHandler = new();

            while (true)
            {
               Console.WriteLine("Strategy");
                var message = "This is the message";

                Console.WriteLine("1: Choose message type");
                Console.WriteLine("2: SMS");
                Console.WriteLine("3: Email");
                Console.WriteLine("4: Facebook Message");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        messageHandler.Send(message);
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("SMS chosen");
                        messageHandler.Message = sendSMS;
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Email chosen");
                        messageHandler.Message = sendEmail;
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Facebook chosen");
                        messageHandler.Message = sendFacebookMessage;
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
            }

            // Refactor this code so that it uses the strategy Pattern
            // What i want to happen to happen is
            //
            // Change type of message to send to sms etc.
            // send message            
        }
    }
}