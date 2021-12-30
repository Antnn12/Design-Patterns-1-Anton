using Design_Patterns_Assignment;
using Design_Patterns_Assignment.Decorator;
using Design_Patterns_Assignment.Decorator.Decorators;
using System;

namespace Design_Patterns_Assignment
{
    internal class Decorator1
    {
        internal static void Run()
        {
            // Refactor this code so that it uses the Decorator Pattern
            Console.WriteLine("Decorator");
            Console.WriteLine("Please enter the text.");
            IText userText = new Text(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("1. Bold");
            Console.WriteLine("2. Deleted");
            Console.WriteLine("3. Emphasized");
            Console.WriteLine("4. Important");
            Console.WriteLine("5. Inserted");
            Console.WriteLine("6. Italic");
            Console.WriteLine("7. Marked");
            Console.WriteLine("8. Smaller");
            Console.WriteLine("9. SubScript");
            Console.WriteLine("0. SuperScript");
            Console.WriteLine();
            Console.WriteLine("Enter the tag you wish to add.");

            while (true)
            {
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Bold tag added.");
                        userText = new Bold(userText);
                        break;
                    case "2":
                        Console.WriteLine("Deleted tag added.");
                        userText = new Deleted(userText);
                        break;
                    case "3":
                        Console.WriteLine("Emphasized tag added.");
                        userText = new Emphasized(userText);
                        break;
                    case "4":
                        Console.WriteLine("Important tag added.");
                        userText = new Important(userText);
                        break;
                    case "5":
                        Console.WriteLine("Inserted tag added.");
                        userText = new Inserted(userText);
                        break;
                    case "6":
                        Console.WriteLine("Italic tag added.");
                        userText = new Italic(userText);
                        break;
                    case "7":
                        Console.WriteLine("Marked tag added.");
                        userText = new Marked(userText);
                        break;
                    case "8":
                        Console.WriteLine("Smaller tag added.");
                        userText = new Smaller(userText);
                        break;
                    case "9":
                        Console.WriteLine("Subscript tag added.");
                        userText = new SubScript(userText);
                        break;
                    case "0":
                        Console.WriteLine("Superscript tag added.");
                        userText = new SuperScript(userText);
                        break;
                    case "F":
                        Console.Clear();
                        Console.WriteLine($"Text: {userText.GetText()}");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}