using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuestions
{
    public class TestMain
    {
        int firstNum = 0, secondNum = 1, thirdNum = 0;
        int revNum = 0;
        public void print()
        {
            Console.WriteLine("Enter the no to print FibonacciSeries");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(firstNum + "\n" + secondNum);
            while (num > 0)
            {
                thirdNum = firstNum + secondNum;
                Console.WriteLine(thirdNum);
                firstNum = secondNum;
                secondNum = thirdNum;
                num--;
            }
        }
    }
}
