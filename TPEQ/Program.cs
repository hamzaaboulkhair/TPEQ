using System;

namespace SolveApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coefficients a, b, c:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            var solution = SolveQuadratic(a, b, c);

            if (solution.X1.HasValue && solution.X2.HasValue)
            {
                Console.WriteLine($"Roots: X1={solution.X1}, X2={solution.X2}");
            }
            else
            {
                Console.WriteLine("No real roots");
            }
        }

        public static Solution SolveQuadratic(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                return new Solution(null, null); // No real roots
            }

            double sqrtD = Math.Sqrt(discriminant);
            double x1 = (-b + sqrtD) / (2 * a);
            double x2 = (-b - sqrtD) / (2 * a);

            return new Solution(x1, x2);
        }
    }
}
