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
            return $"{a} + {b} = {a + b}";
        }

        
        
    }
}
