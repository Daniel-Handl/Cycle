using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cykli
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int n;
            Console.Write("Zadej x a n \nx: ");
            Int32.TryParse(Console.ReadLine(), out x);
            Console.Write("n: ");
            Int32.TryParse(Console.ReadLine(), out n);
            Console.WriteLine(While(x, n));
            Console.WriteLine(For(x, n));
            Console.WriteLine(Do_While(x, n));
            Console.WriteLine(Recurrent(x, n, 1.0));
            Console.ReadLine();
        }

        private static double Recurrent(double x, double n, double S)
        {
            if (n>0)
            {
                S += n * x / Factorial(n--);
                Recurrent(x, n, S);
            }
            return S;
        }
        private static double Do_While(int x, int n)
        {
            double S = 1.0;
            do
            {
                S += n * x / Factorial(n--);
            } while (n > 0);
            return S;
        }
        private static double For(int x, int n)
        {
            double S = 1.0;
            for (int i = 1; i <= n; i++)
            {
                S += i * x / Factorial(i);
            }
            return S;
        }
        private static double While(int x, int n)
        {
            double S = 1.0;
            while (n>0)
            {
                S += n * x / Factorial(n--);
            }
            return S;
        }
        private static double Factorial(double r)
        {
            double l = r; 
            for (int i = 1; i < l; i++)
            {
                r *= i;
            }
            return r;
        }
    }
}
