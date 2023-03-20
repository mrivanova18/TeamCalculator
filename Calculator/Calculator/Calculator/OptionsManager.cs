using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
  public static  class OptionsManager
    {
        public static string[] OptionsList = {
            "ex - Exit",
            "a - Add",
            "s - Subtract",
            "m - Multiply",
            "d - Devide",
            "sabs - SubtractAbs",
            "dr - DevideReminder",
            "pow - Power",
            "log - Logarithm",
            "min - Minimum",
            "max - Maximum",
            "avg - Average",
            "sqrt - SumSquareRoots",
            "sq - SumSquares"
            };

        public static string Add(double a, double b)
        {
            return $"{a}+{b}={a + b}";
        }

        public static string Multiply(double a, double b)
        {
            return $"{a}*{b}={a * b}";
        }
        
        public static string Subtract(double a , double b)
        {
            return $"{a} - {b} = {a - b}";
        }
            return $"{a}-{b}={a - b}";
        }      

        public static string Devide(double a, double b)
        {
            if (b == 0)
            {
                throw new InvalidOperationException("Is not divisible by zero");
            }
            else
            {
                return $"{a} / {b} = {a / b}";
            }
        }

            public static string Average(double a, double b)
            {
                return $"{a} + {b} = ({a} + {b} / 2) ";
            }
                return $"{a}/{b}={a / b}";
            }                       
        }

        public static string SumSquareRoots(double a, double b)
        {
            if (a < 0 || b < 0)
            {
                throw new InvalidOperationException("The numbers must be positive or 0");
            }
            else
            {
                return $"Square root of {a} + square root of {b} = {Math.Sqrt(a) + Math.Sqrt(b)}";               
            }
        }
        public static string Logarithm(double a, double b)
        {
            if (a <= 0)
            {
                throw new InvalidOperationException("The number must be positive");
            }
            else if (b <= 0 || b == 1)
            {
                throw new InvalidOperationException("The base must be positive and different from 1");
            }
            else
            {
                return $"Log of {a} by base {b} = {Math.Log(a,b)}";
            }

        public static string SubtractAbs(double a, double b)
        {
            double res = Math.Abs(a - b);
            return $"{a}-{b}={res}";
        }

        public static string DevideReminder(double a, double b)
        {
            if (b==0)
            {
                throw new InvalidOperationException("Is not divisible by zero");
            }

            double res = a % b;
            return $"{a}/{b}={res}";
        }

        public static string Power(double a, double b)
        {
            double res = Math.Pow(a,b);
            return $"{a}^{b}={res}";
        }

        public static string Minimum(double a, double b)
        {
            double res = Math.Min(a, b);
            return $"Min({a},{b})={res}";
        }

        public static string Maximum(double a, double b)
        {
            double res = Math.Max(a, b);
            return $"Max({a},{b})={res}";
        }
    }
