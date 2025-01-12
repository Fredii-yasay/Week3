namespace Assignment3
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
            Console.WriteLine("Enter an integer: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            PrintMultiplicationTable(number);
        }

        void PrintMultiplicationTable(int number)
        {
            int product;

            for (int i = 1; i <= 10; i++)
            {
                product = i * number;

                Console.WriteLine($"{i} x {number} = {product}");
            }
        }
    }
}
