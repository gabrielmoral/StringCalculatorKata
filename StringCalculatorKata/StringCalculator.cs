using System;
using System.Linq;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public static int Add(string expression)
        {
            if (expression == string.Empty) return 0;

            var addends = ExpressionParser.ParseAddends(expression);

            return Sum(addends);            
        }

        private static int Sum(string[] addends)
        {
            return addends.Select(int.Parse).Sum();
        }
    }
}