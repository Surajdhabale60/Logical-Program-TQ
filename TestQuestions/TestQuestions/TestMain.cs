using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuestions
{
    internal class TestMain
    {
        public void Fibonacci(int num)
        {
            
            int a = 0, b = 1;
            Console.Write("Fibonacci Series is : " + a + " " + b);
            for (int i = 0; i < num; i++)
            {
                int c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }

        public void ReverseNum(int num)
        {
            int reverse = 0;
            Console.WriteLine("Number before Reverse is : " + num);
            while (num > 0)
            {
                int remainder = num % 10;
                reverse = reverse * 10 + remainder;

                num /= 10;
            }
            Console.WriteLine("After reverse number is :" + reverse);
        }
    }
}
