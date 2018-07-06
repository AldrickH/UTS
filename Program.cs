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
                }
                else if(x > 1000 || x < -1000 || n > 1000 || n < -1000){
                    Console.WriteLine("Maaf angka terlalu besar");
                    return res;
                }
                else
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
            if (x >= 0 && x <= 1000) return true;
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Aplikasi SumX ");
            Console.WriteLine("=============");
            Console.WriteLine();
            Console.WriteLine("sumX(3, 10): " + (sumX(3, 10) == 18));
            Console.WriteLine("sumX(1, 10): " + (sumX(1, 10) == 55));
            Console.WriteLine("sumX(0, 10): " + (sumX(0, 10) == 0));
            Console.WriteLine("SumX(1500, 100) : " + (sumX(1500,100) ==0));
            Console.WriteLine("sumX(-1, 10): " + (sumX(-1, 10) == 0));
            Console.WriteLine("sumX(-1, -10): " + (sumX(-1, -10) == -55));
        }
    }
}
