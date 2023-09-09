using Serilog;

namespace Lab2Pro;

internal class Operation
{
    public static (string, int) GetSum(string a, string b)
    {
        try
        {
            Log.Information($"Request sum of two numbers: {a} && {b}.");

            int x = Convert.ToInt32(a);
            int y = Convert.ToInt32(b);

            if (x > 0 && y > 0)
            {
                string textResult = "OK";
                int sumResult = x + y;

                Log.Debug($"Sum of a = {a} and b = {b} eq. {sumResult}. It's '{textResult}'.");
                return (textResult, sumResult);
            }
            else
            {
                Log.Warning($"Negative variable(s): a = {a} or b = {b}.");
                return ("NOK", -1);
            }
        }
        catch (Exception exp)
        {
            Log.Error($"Incorrect values of a = {a} or b = {b}.");
            Log.Error("Exception: {}\n{}", exp.Message, exp.StackTrace);
            return ("ERROR", -2);
        }
    }
}
