internal static class ExpressionParser
{
    public static string[] ParseAddends(string expression)
    {
        const string newLineSeparator = "\n";
        const string commaSeparator = ",";

        var normalisedExpression = expression;
        
        if (expression.Contains(newLineSeparator))
        {
            normalisedExpression = expression.Replace(newLineSeparator, commaSeparator);                    
        }

        return normalisedExpression.Split(commaSeparator);
    }
}