namespace TestQuestions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nselect Program\n 1.FibonacciSeries\n 2.ReverseNum");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        TestMain testMain = new TestMain();
                        testMain.print();
                        break;                   
                }
            }
        }
    }
}
