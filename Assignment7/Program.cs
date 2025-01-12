namespace Assignment7
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
            Console.WriteLine("Enter dimension size: ");
            string input = Console.ReadLine();
            int dimension = int.Parse(input);

            PrintSquare(dimension);
        }

        void PrintSquare(int dimension)
        {
            for (int i = 0; i < dimension; i++)
            {
                Console.WriteLine("X");
                for (int j = 0; j < dimension - 1; j++)
                {
                    Console.WriteLine(" X");
                }
            }
        }
    }
}
