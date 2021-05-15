using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2, delta;
            try
                {
                Console.WriteLine("ax^2 + bx + c = 0");
                Console.WriteLine("I need a value of a, b and c.");
                Console.WriteLine("What's the values of a ?");
                a= Convert.ToDouble(Console.ReadLine());
                if (a == 0) { throw new Exception("a has to be larger than 0"); }

                Console.WriteLine("What's the value of b ?");
                b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("And last, what's the values of c ?");
                c= Convert.ToDouble(Console.ReadLine());

                

                delta = b * b - 4 * a * c;
                Console.WriteLine("Delta = " + delta);

                if(delta>0)
                {
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(delta))/ (2 * a);
                    Console.WriteLine("The solutions for this equation are:{0} {1}", x1, x2);
                    
                }
                else if(delta==0)
                {
                    x1 = x2 = (-b) / (2 * a);
                    Console.WriteLine("The solution for this equation is: {0}", x1);
                    
                }
                else
                {
                    Console.WriteLine("No solutions for this equation");
                    
                }
                Console.WriteLine("");
                Console.WriteLine("y = {0}x^2 + {1}x + {2}", a, b, c);

                double p = (-b) / (2 * a);
                double q = (-delta)/(4 * a);

                MaxMin(p, q, a);
                NegativePositive(delta, a, b, c);

                Console.ReadKey();
            }
            catch(Exception error)
                {
                Console.WriteLine("Programme stopped. Code: {0}", error.Message);
                Console.ReadKey();
                }
            
        }
        public static void MaxMin(double p1, double q1, double a1)
        {
            if (a1 > 0)
            {
                Console.WriteLine("Max value of this function is: infinity");
                Console.WriteLine("Min value of this finction is: {0}", q1);

            }
            else if (a1 < 0)
            {
                Console.WriteLine("Max value of this function is: {0}", q1);
                Console.WriteLine("Min value of this finction is: -infinity");
            }
        }
        public static void NegativePositive(double d, double a, double b, double c)
        {
            double x1, x2;
            if (a > 0)
            {
                if (d >= 0)
                {
                    x1 = (-b - Math.Sqrt(d)) / (2 * a);
                    x2 = (-b + Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("The function has positive values in (-infinity, {0}) and ({1}, infinity)", x1, x2);
                    if (d > 0) { Console.WriteLine("The function has negative values in ({0},{1})", x1, x2); }
                }
                else { Console.WriteLine("Function has only positive values."); }
            }
            else if (a < 0)
            {
                if (d >= 0)
                {
                    x1 = (-b - Math.Sqrt(d)) / (2 * a);
                    x2 = (-b + Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("The function has negative values in (-infinity, {0}) and ({1}, infinity)", x1, x2);
                    if (d > 0) { Console.WriteLine("The function has positive values in ({0},{1})", x1, x2); }
                }
                else { Console.WriteLine("Function has only negative values."); }
            }
        }
    }
}
