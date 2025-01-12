namespace Assignment8
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
            Console.WriteLine("Enter number of elements: ");
            string input = Console.ReadLine();
            int element = int.Parse(input);

            int sum = CalculateSum(element);
            double average = CalculateAverage(sum, element);

            Console.WriteLine($"The sum is {sum}");
            Console.WriteLine($"The average is {average}");
        }

        int CalculateSum(int element)
        {
            int sum = 0;

            for (int i = 1; i < element + 1; i++)
            {
                Console.WriteLine($"Enter number {i}: ");
                string input = Console.ReadLine();
                int number = int.Parse(input);

                sum += number;
            }

            return sum;
        }

        double CalculateAverage(int sum, int element)
        {
            return (double)sum / (double)element;
        }
    }
}
