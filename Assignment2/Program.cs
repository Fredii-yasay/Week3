namespace Assignment2
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
            Console.WriteLine("Enter a positive integer: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            int result = CalculateFactorial(number);

            Console.WriteLine($"The factorial of {number} is {result}.");
        }

        int CalculateFactorial(int number)
        {
            int product = 1;

            for (int i = 1; i < number + 1; i++)
            {
                product = product * i;
            }

            return product;
        }
    }
}
