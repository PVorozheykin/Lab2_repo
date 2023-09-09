using Serilog;

namespace Lab2Pro;

internal class Operation
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static (string, int) GetSum(string a, string b)
    {
        try
        {
            Log.Information($"Request sum of two numbers: {a} && {b}.");

            int x = Convert.ToInt32(a);
            int y = Convert.ToInt32(b);

            if (ArePositive(x, y))
            {
                string textResult = "OK";
                int sumResult = x + y;

                Log.Information($"Sum of a = {a} and b = {b} eq. {sumResult}. It's '{textResult}'.");
                
                return (textResult, sumResult);
            }
            else
            {
                Log.Warning($"Sum of two begative numbers: a = {a} or b = {b}. It's 'NOK'.");
            
                return ("NOK", -1);
            }
        }
        catch (Exception exp)
        {
            Log.Error($"Sum of two incorrect values: a = {a} or b = {b}. It's 'ERROR'.");
            Log.Error("Exception: {0}\n{1}", exp.Message, exp.StackTrace);

            return ("ERROR", -2);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="mass"></param>
    /// <returns></returns>
    private static bool ArePositive(params int[] mass)
    {
        return mass.All(x => x > 0);
    }
}
