using System.Numerics;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            int calcinput = 0;
            do
            {
                DisplayMenu();

                string input1 = Console.ReadLine();
                calcinput = int.Parse(input1);

                if (calcinput != 5)
                {
                    Console.WriteLine("Enter first number:");
                    string input2 = Console.ReadLine();
                    int first = int.Parse(input2);

                    Console.WriteLine("Enter second number:");
                    string input3 = Console.ReadLine();
                    int second = int.Parse(input3);

                    PerformCalculation(calcinput, first, second);
                }
            }
            while (calcinput != 5);
        }

        void DisplayMenu()
        {
            Console.WriteLine("Simple Calculator Menu:\n" +
                    "1. Addition\n" +
                    "2. Subtraction\n" +
                    "3. Multiplication\n" +
                    "4. Division\n" +
                    "5. Exit\n\n" +
                    "Enter your choice: ");
        }

        void PerformCalculation(int calcinput, int first, int second)
        {
            int result = 0;
            if (calcinput == 1)
            {
                result = Addition(first, second);
            }
            else if (calcinput == 2)
            {
                result = Subtraction(first, second);
            }
            else if (calcinput == 3)
            {
                result = Multiplication(first, second);
            }
            else if (calcinput == 4)
            {
                result = Division(first, second);
            }
            
            if (calcinput > 5)
            {
                Console.WriteLine("Error!");
            }
            else if (calcinput < 5)
            {
                Console.WriteLine($"Result: {result}");
            }
        }

        int Addition(int a, int b)
        {
            return a + b;
        }

        int Subtraction(int a, int b)
        {
            return a - b;
        }

        int Multiplication(int a, int b)
        {
            return a * b;
        }

        int Division(int a, int b)
        {
            return a / b;
        }
    }
}
