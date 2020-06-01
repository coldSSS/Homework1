using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] s = new int[100];
            for (int i = 0; i < s.Length; i ++) 
            {
                s[i] = i + 1;
            }

            for (int i = 2; i*i <= 100; i++) 
            {
                for (int j = 2; i * j <= 100; j++) 
                {
                    s[i*j-1] = 0;
                }
            }

            s[0] = 0;
            for (int i = 0; i < 100; i++) 
            {
                if (s[i] != 0)
                {
                    Console.Write("{0},", s[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
