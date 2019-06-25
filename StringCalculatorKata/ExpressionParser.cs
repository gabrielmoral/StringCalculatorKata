using System.Collections.Generic;
using System.Linq;

internal static class ExpressionParser
{
    public static string[] ParseAddends(string expression)
    {
        const string newLineSeparator = "\n";
        const string commaSeparator = ",";
        const string customSeparatorIdentifier = "//";

        var replaceableSeparators = new List<string>
        {
            newLineSeparator
        };

        if (expression.StartsWith(customSeparatorIdentifier))
        {
            var customSeparator = expression.Substring(2, 1);
            
            replaceableSeparators.Add(customSeparator);

            expression = expression.Replace(customSeparatorIdentifier + customSeparator, string.Empty);
        }

        foreach (var separator in replaceableSeparators)
        {
            expression = expression.Replace(separator, commaSeparator);                                
        }

        return expression.Split(commaSeparator)
            .Where(x => !string.IsNullOrEmpty(x))
            .ToArray();
    }
}