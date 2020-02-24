using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("请输入一整数：");
                    num = int.Parse(Console.ReadLine());
                    flag = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("输入格式不正确或输入为空");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("溢出");
                }
            }

            Console.WriteLine("{0}的素因子为：", num);
            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    if (IsPrime(i))
                        Console.Write("{0},", i);
                }
            }

            Console.ReadLine();

        }


        private static bool IsPriem(int num) 
        {
            bool isTrue = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isTrue = false;
                    break;
                }
            }

            return isTrue;
        }
    }
}
