internal static class ExpressionParser
{
    public static string[] ParseAddends(string expression)
    {
        const string newLineSeparator = "\n";
        const string commaSeparator = ",";
            
        if (expression.Contains(newLineSeparator))
        {
            return expression.Split(newLineSeparator);                    
        }

        return expression.Split(commaSeparator);
    }
}