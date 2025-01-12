namespace Theory3
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
            Console.WriteLine("Enter a positive integer");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            int result = CalculateSum(number);

            Console.WriteLine($"The sum of natural numbers from 1 to {number} is {result}.");
        }

        int CalculateSum(int number)
        {
            int sum = 0;
            for (int i = 1; i < number + 1; i++)
            {
                sum = sum + i;
            }

            return sum;
        }
    }
}
