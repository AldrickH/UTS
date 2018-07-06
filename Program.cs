using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int sumX(int x, int n)
        {
            int res = 0;
            int temp = 0;

            if (x != 0)
            {
                if ((checkNum(x) && checkNum(n)))
                {
                    while (x <= n)
                    {
                        temp += x;
                        res += temp;
                        n -= x;
                    }
                    return res;
                } else
                {
                    while (x >= n)
                    {
                        temp += x;
                        res += temp;
                        n -= x;
                    }
                    return res;
                }
            }
            return res;
        }

        static bool checkNum(int x)
        {
            if (x >= 0) return true;
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("sumX(3, 10): " + (sumX(3, 10) == 18));
            Console.WriteLine("sumX(1, 10): " + (sumX(1, 10) == 55));
            Console.WriteLine("sumX(0, 10): " + (sumX(0, 10) == 0));
            Console.WriteLine("sumX(-1, 10): " + (sumX(-1, 10) == 0));
            Console.WriteLine("sumX(-1, -10): " + (sumX(-1, -10) == -55));
        }
    }
}
