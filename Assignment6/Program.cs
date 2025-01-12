namespace Assignment6
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
            Console.WriteLine("Enter a number greater than 1: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            bool prime = IsPrime(number);

            if (prime)
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }

        bool IsPrime(int number)
        {
            int i = 2;
            while (i < number)
            {
                if (number % i == 0)
                {
                    return false;
                }
                else
                {
                    i = i + 1;
                }
            }

            return true;
        }
    }
}
