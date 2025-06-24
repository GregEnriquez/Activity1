using System;

namespace Activity1
{
    class Program
    {
        static void Subtraction()
        {
            Console.Write("Enter the minuend: ");
            int minuend = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the subtrahend: ");
            int subtrahend = Convert.ToInt32(Console.ReadLine());
            int diff = minuend - subtrahend;
            Console.WriteLine("The difference is: " + diff);
            Console.WriteLine("");
        }

        static void Division()
        {
            Console.Write("Enter the dividend: ");
            float dividend = float.Parse(Console.ReadLine());
            Console.Write("Enter the divisor: ");
            float divisor = float.Parse(Console.ReadLine());
            float quotient = dividend / divisor;
            Console.WriteLine("The quotient is: " + quotient.ToString("F2"));
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            Console.Write("Hello! What's your name? ");
            string name = Console.ReadLine();
            
            Console.WriteLine("");
            Console.WriteLine("Greetings, " + name + "! Kindly choose what you want to do.");
            Console.WriteLine("");
            
            Console.WriteLine("Please input the number only (1 or 2).");
            Console.WriteLine("1. Subtraction");
            Console.WriteLine("2. Division");
            Console.WriteLine("3. Exit");
            Console.WriteLine("");

            while (true)
            {
                Console.WriteLine("--------------------------------------");
                Console.Write("Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");
                if (choice == 1)
                {
                    Subtraction();
                }
                else if (choice == 2)
                {
                    Division();
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Thank you, " + name + "!");
                    Console.WriteLine("");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input !!!");
                    Console.WriteLine("Try again.");
                    Console.WriteLine("");
                }
            }
        }
    }
}
