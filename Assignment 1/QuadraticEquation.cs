using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class QuadraticEquation
    {
        private double A, B, C;
        public QuadraticEquation(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public void CalculateRoots()
        {
            double discriminant = (B * B) - (4 * A * C);

            if (discriminant > 0)
            {
                double root1 = (-B + Math.Sqrt(discriminant)) / (2 * A);
                double root2 = (-B - Math.Sqrt(discriminant)) / (2 * A);
                Console.WriteLine($"The roots are real and distinct: Root1 = {root1}, Root2 = {root2}");
            }
            else if (discriminant == 0)
            {
                double root = -B / (2 * A);
                Console.WriteLine($"The roots are real and equal: Root = {root}");
            }
            else
            {
                double realPart = -B / (2 * A);
                double imaginaryPart = Math.Sqrt(-discriminant) / (2 * A);
                Console.WriteLine($"The roots are complex: Root1 = {realPart} + {imaginaryPart}i, Root2 = {realPart} - {imaginaryPart}i");
            }
        }
    }
}
