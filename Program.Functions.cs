using System.Globalization;
using System.Diagnostics;
using System.Runtime.CompilerServices;

partial class Program
{
    static void TimesTable(byte number, byte size = 12)
    {
        WriteLine($"THis is the {number} times table with {size} rows");
        WriteLine();

        for (int row = 1; row <= size; row++)
        {
            WriteLine($"{row} * {number} = {row * number}");
        }

        WriteLine();
    }

    static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
    {
        decimal rate = twoLetterRegionCode switch
        {
            "CH" => 0.08M,
            "DK" or "NO" => 0.25M,
            "GB" or "FR" => 0.2M,
            "HU" => 0.27M,
            "OR" or "AK" or "MT" => 0.0M,
            "CA" => 0.0825M,
            _ => 0.06M
        };

        return amount * rate;
    }

    static void ConfigureConsole(string culture = "en-US", bool useComputerCulture = false)
    {
        OutputEncoding = System.Text.Encoding.UTF8;

        if (!useComputerCulture)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
        }

        WriteLine($"CurrentCulture: {CultureInfo.CurrentCulture.DisplayName}");
    }

    static void LogSourceDetails(
        bool condition,
        [CallerMemberName] string member = "",
        [CallerFilePath] string filepath = "",
        [CallerLineNumber] int line = 0,
        [CallerArgumentExpression(nameof(condition))] string expression = "")
    {
        WriteLine(string.Format(
            "[{0}]\n {1} on line {2}. Expression: {3}",
            filepath, member, line, expression
        ));
    }
}