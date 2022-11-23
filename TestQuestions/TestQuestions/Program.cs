namespace TestQuestions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nselect Program\n 1.Fibonacci Series\n 2.Reverse Number\n 3.Perfect Number");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        TestMain testMain = new TestMain();
                        testMain.print();
                        break;
                    case 2:
                        TestMain testMain1 = new TestMain();
                        testMain1.ReverseNum();
                        break;
                    case 3:
                        TestMain main2 = new TestMain();
                        main2.PerfectNumber();
                        break;
                    case 4:
                        TestMain main3 = new TestMain();
                        main3.CheckPrime();
                        break;
                }
            }
        }
    }
}
