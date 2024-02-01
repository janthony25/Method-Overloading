using System;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Method overloading = methods share the same name, but different parameters
            //                      name + parameters = signature
            //                      methods must have a unique signature


            double total;

            total = Multiply(2.4, 4, 3);

            Console.WriteLine(total);


            Console.ReadKey();
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Multiply(double a, double b, double c)
        {
            return (a * b + c);
        }
    }
}