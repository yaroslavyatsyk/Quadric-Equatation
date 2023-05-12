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
       private double k; // for even second coef
      

       public QuadricEquatation(double _a, double _b, double _c)
       {
            a = _a;
           b = _b;
            c = _c;
       }

        internal object CalculateResults()
        {
            throw new NotImplementedException();
        }

        private double CalculateDiscriminate()
        {
            if ((int)b % 2 != 0)
            {
                return Math.Pow(b, 2.0) - 4 * a * c;
            }
            else
            {
                return Math.Pow(b, 2.0) - a * c;
            }
        }
        public dynamic CalculateSolutions<T>()
        {
            if(CalculateDiscriminate() > 0)
            {
                double x1 = ((-b) + Math.Sqrt(CalculateDiscriminate())) / (2 * a);
                double x2 = ((-b) + Math.Sqrt(CalculateDiscriminate())) / (2 * a);

                return new QuadricResults(x1,x2);
            }
            else if(CalculateDiscriminate() == 0)
            {
                return -b / (2 * a);
            }
            else
            {
                return "No Solutions";
            }
        }
     

       
       }
   }
