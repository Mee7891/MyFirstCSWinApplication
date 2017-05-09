using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCSWinApplication
{
    static class MathUtils
    {
        public static void SimpleFactors(int n, bool repets, IPrinterEnumerable<int> printer)
        {
            List<int> factors = new List<int>();

            //Простой алгоритм
            //int i = 2;
            //while (i < n)
            //{
            //    while (n % i == 0)
            //    {
            //        if(repets || factors.Count==0 || factors.Last()!=i)
            //            factors.Add(i);
            //        n = n / i;
            //    }

            //    i++;
            //}

            //Усовершенствованный
            //Вначале разбираемся с четными множителями, простой из которых только 2
            while (n % 2 == 0)
            {
                if (repets || factors.Count == 0)
                    factors.Add(2);
                n /= 2;
            }

            int i = 3;
            int max_factor = (int)Math.Sqrt(n); //смысл считать есть только до корня включительно
            while (i <= max_factor)
            {
                while (n % i == 0)
                {
                    if (repets || factors.Count == 0 || factors.Last() != i) 
                        factors.Add(i);
                    n /= i;
                    max_factor = (int)Math.Sqrt(n);
                }
                i += 2;
            }

            if (n > 1) factors.Add(n);

            printer.PrintEnumerable(factors);
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static void Swap<T>(T a, T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
