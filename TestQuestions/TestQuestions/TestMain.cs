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
        public void ReverseNum()
        {
                Console.WriteLine("Enter No");
                int num = Convert.ToInt32(Console.ReadLine());
                while (num > 0)
                {
                    int reminder = num % 10;
                    revNum = revNum * 10 + reminder;
                    num = num / 10;
                }
                Console.WriteLine(revNum);   
        }
        public void PerfectNumber()
        {
            int sum = 0;
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            if (num == sum)
                Console.WriteLine("Number Entered is Perfect Number");
            else
                Console.WriteLine("Number Entered is not a Perfect Number");
        }
    }
}
