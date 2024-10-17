using System;

namespace p1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for an option
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Check if a number is prime");
            Console.WriteLine("2. Generate Fibonacci series");

            // Read user input for option selection
            int x = Convert.ToInt32(Console.ReadLine());

            // Use switch case for the selected option
            switch (x)
            {
                case 1:
                    PrimeNum(); // Corrected method call
                    break;
                case 2:
                    Fibo(); // Corrected method call
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }

        // Method to check if a number is prime
        static void PrimeNum()
        {
            int n, i, m = 0, flag = 0;
            Console.Write("Enter the number to check if it's prime: ");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Number is not prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine("Number is prime.");
        }

        // Method to generate Fibonacci series
        static void Fibo()
        {
            int n1 = 0, n2 = 1, n3, i, number;
            Console.Write("Enter the number of elements: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");
            for (i = 2; i < number; ++i)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
            Console.WriteLine(); // To add a new line after the series
        }
    }
}
