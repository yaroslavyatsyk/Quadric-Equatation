using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadric_Equatation
{
    public class QuadricEquatation
    {
        private double a, b, c; // Coeficients of equatation;
        

        public QuadricEquatation(double _a, double _b, double _c)
        {
            if(_a == 0)
            {
                throw new ArgumentException("a can't be 0");
            }
            a = _a;
            b = _b;
            c = _c;
        }

        private double CalculateDiscriminate()
        {
           return (b * b) - (4 * a * c);
        }
        public double GetDiscriminate()
        {
            return CalculateDiscriminate();
        }

        public object CalculateEquation()
        {
            double discriminate = GetDiscriminate();

            if(discriminate > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminate)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminate)) / (2 * a);

                return Tuple.Create(x1, x2);
            }
           
            else if(discriminate == 0)
            {
                return -b / (2 * a);
            }
            else
            {
                return "No solution(s)";
            }
        }

    
   }
}
