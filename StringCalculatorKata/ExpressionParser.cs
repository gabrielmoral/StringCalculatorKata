using System.Collections.Generic;
using System.Linq;

internal static class ExpressionParser
{
    public static string[] ParseAddends(string expression)
    {
        const string newLineSeparator = "\n";
        const string commaSeparator = ",";

        var replaceableSeparators = new List<string>
        {
            newLineSeparator
        };

        foreach (var separator in replaceableSeparators)
        {
            expression = expression.Replace(separator, commaSeparator);                                
        }

        return expression.Split(commaSeparator);
    }
}