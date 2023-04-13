using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class RownanieKwadratowe
    {
        private double A;
        private double B;
        private double C;

        public RownanieKwadratowe(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double ObliczDelte()
        {
            return B * B - 4 * A * C;
        }

        public double[] ObliczRozwiazanie()
        {
            double delta = ObliczDelte();

            if (delta < 0)
            {
                throw new Exception("Delta jest ujemna.");
            }
            else if (delta == 0)
            {
                double x = -B / (2 * A);
                return new double[] { x, x };
            }
            else
            {
                double x1 = (-B - Math.Sqrt(delta)) / (2 * A);
                double x2 = (-B + Math.Sqrt(delta)) / (2 * A);
                return new double[] { x1, x2 };
            }
        }
    }
}
