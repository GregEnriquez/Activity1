using System;

namespace Activity1
{
    class Program
    {
        static void Addition()
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the other number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("The sum is: " + sum);
            Console.WriteLine("");
            Console.WriteLine ("Byeeeee...");
            Console.WriteLine("");
        }

        static void Multiplication()
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the other number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int product = num1 * num2;
            Console.WriteLine("The product is: " + product);
            Console.WriteLine("");
            Console.WriteLine("Byeeeee...");
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
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Multiplication");
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
                    Addition();
                }
                else if (choice == 2)
                {
                    Multiplication();
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