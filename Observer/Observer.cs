using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    class Observer1
    {
        public void Update(string email)
        {
            Console.WriteLine(email);
        }

        internal static void Run()
        {
            Console.WriteLine("Observer");
            Observer1 observer = new();
            Email1 email = new();

            while (true)
            {
                Console.WriteLine("Press A to add or remove observer.");
                Console.WriteLine("Press U to update.");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "A" or "a":
                        email.CheckTimer();
                        break;
                    case "U" or "u":
                        if (email.ObserverList.Contains(observer))
                        {
                            email.Unregister(observer);
                            Console.WriteLine("Unregistered.");
                        }
                        else
                        {
                            email.Register(observer);
                            Console.WriteLine("Registered.");
                        }
                        break;
                    case "E" or "e":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
