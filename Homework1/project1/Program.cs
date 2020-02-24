using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            double? result;//声明结果
            bool flag3 = true;
            bool flag4 = true;
            char s, f;
            double? fnum = 0, snum = 0;//两个操作数

            while (flag4)
            {
                setFirst(ref fnum);//分别set设置firstnum和secondnum
                setSecond(ref snum);

                Console.WriteLine("请输入运算符，加为+，减为-，乘为*，除为/");

                while (flag3)
                {
                    try
                    {
                        s = (char)Console.Read();
                        result = Fc1((double)fnum, (double)snum, s);
                        Console.WriteLine("结果为{0}", result);
                        flag3 = false;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("数字过大，计算失败");
                        flag3 = false;
                    }
                    catch (DivideByZeroException) //若除数为零，则重新set第二个操作数
                    {
                        Console.WriteLine("除数不能为零");
                        setSecond(ref snum);
                        Console.WriteLine("请重新输入运算符:");
                    }
                    catch (Exception)//无效符号
                    {
                        Console.WriteLine("无效符号，请重新输入：");
                    }
                }

                Console.WriteLine("按任意键继续计算，按q离开");
                Console.ReadLine();
                f =(char)Console.Read();
                if (f == 'q')
                    flag4 = false;
            }

            Console.ReadLine();
            Console.Read();


        }

        static double Fc1(double fnum, double snum, char s)
        {
            double result = 0;
            switch (s)
            {
                case '+':
                    result = fnum + snum;
                    break;
                case '-':
                    result = fnum - snum;
                    break;
                case '*':
                    result = fnum* snum;
                    break;
                case '/':
                    result = fnum / snum;
                    break;
                default:
                    throw new Exception();
            }

            return result;

        }
        static void setFirst(ref double? fnum) 
        {
            bool flag1 = true;
            Console.Write("请输入第一个数:");
            while (flag1)
            {
                try
                {
                    fnum = double.Parse(Console.ReadLine());
                    flag1 = false;
                }
                catch (Exception)//输入非法或为空
                {
                    Console.WriteLine("输入为空或非法输入！请重新输入第一个数：");
                }
            }
        }

        static void setSecond(ref double? snum) 
        {
            bool flag2 = true;
            Console.Write("请输入第二数:");
            while (flag2)
            {
                try
                {
                    snum = double.Parse(Console.ReadLine());
                    flag2 = false;
                }
                catch (FormatException) //调整程序执行逻辑使其输出合理，ps：可以试一下去掉这个catch有什么后果
                { }
                catch (Exception)//输入非法或为空
                {
                    Console.WriteLine("输入为空或非法输入！请重新输入第二个数：");
                }
            }
        }
    }
}
