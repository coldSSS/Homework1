using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCalculate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] s = {1,13,26,10,7,19,58};

            Calculate(s,out int max, out int min, out int sum, out double Average);
            Average = (double)sum / s.Length;

            Console.WriteLine("max:{0}, min:{1},sum:{2},Average:{3}", max, min, sum, Average);

            Console.ReadLine();

        }

        private static void Calculate(int[] s, out int max, out int min, out int sum, out double Average) 
        {
            int temp;
            max = s[0];
            min = s[0];
            sum = s[0];
            for (int i = 1; i < s.Length; i++)
            {
                temp = s[i];
                if (temp > max)
                {
                    max = temp;
                }
                if (temp < min)
                {
                    min = temp;
                }
                sum = sum + s[i];
            }
            Average = (double)sum / s.Length;
        }
    }

}
