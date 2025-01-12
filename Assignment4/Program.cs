namespace Assignment4
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
            Console.WriteLine("Enter the start of the range: ");
            string input1 = Console.ReadLine();
            int start = int.Parse(input1);

            Console.WriteLine("Enter the end of the range: ");
            string input2 = Console.ReadLine();
            int end = int.Parse(input2);

            (int EvenCount, int OddCount) = CountEvenandOdd(start, end);

            Console.WriteLine($"Between number {start} to {end}:\n Number of Even Numbers: {EvenCount}\n Number of Odd Numbers:  {OddCount}");
        }

        (int, int) CountEvenandOdd(int start, int end)
        {
            int EvenCount = 0, OddCount = 0;

            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    EvenCount++;
                }
                else if (i % 2 == 1)
                {
                    OddCount++;
                }
            }

            return (EvenCount, OddCount);
        }
    }
}
