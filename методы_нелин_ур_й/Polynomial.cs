using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace методы_нелин_ур_й
{
    class Polynomial
    {
       public int order (double[] coefficients)
        {
            return coefficients.Length - 1;
        }
        public double func (double[] coefficients, double x, int order)
        {
            double answer=0;
            for (int i = 0; i <= order; i++)
            {
                answer += coefficients[i] * Math.Pow(x,(order - i));
            }
            return answer;
        }
        public double [] derivate_coef(double[] coefficients, int order)
        {
            double[] derivatecoef = new double[order];
            for (int i =0; i<=order-1; i++)
            {
                derivatecoef[i] = coefficients[i] * (order - i);
            }
            return derivatecoef;
        }
        public double minOfDerivate(double a, double b, double[]coefficients)
        {
            return Math.Min(Math.Abs(func(coefficients, a, coefficients.Length-1)), Math.Abs((func(coefficients, b, coefficients.Length-1))));
        }
        public double MaxOfDerivate(double a, double b, double[] coefficients)
        {
            return Math.Max(Math.Abs(func(coefficients, a, coefficients.Length-1)), Math.Abs(func(coefficients, b, coefficients.Length-1)));
        }
        public int IsSignConst (double func_a, double func_b)
        {
            if (func_a * func_b < 0)
            {
                return -1;
            }
            else if (func_a * func_b > 0)
            {
                return 1;
            }
            else return 0; 

        }
        public double newX_MI(double x, double lamda, double f)
        {
            return x - lamda * f;
        }
        
        public double newX_MN(double x, double[] coefficients, int order)
        {
            double[] derivcoef = this.derivate_coef(coefficients, order);
            double func = this.func(coefficients, x, order);
            double deriv = this.func(derivcoef, x, order - 1);
            return x - (func / deriv);
        }
        public double newX_MH(double x, double[] coefficients, int order, double a_notmove)
        {           
            double func = this.func(coefficients, x, order);
            double funcA = this.func(coefficients, a_notmove, order);
            return x - ((func*(x-a_notmove )) / (func-funcA));
        }
        public double finish (double func_x, double m1)
        {
            return Math.Abs(func_x) / m1;
        }
       public double newX_Dikhot(double a, double b)
        {
            return (a + b) / 2;
        }
        public double finish_Dikh(double a, double b)
        {
            return (b - a) / 2;
        }
    }
}
