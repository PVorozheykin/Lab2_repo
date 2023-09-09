using Serilog;

namespace Lab2Pro;

internal class Program
{
    static void Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Verbose()
            .WriteTo.Console()
            .WriteTo.File("log/file.log")
            .CreateLogger();

        Log.Information("Application start!");

        // Работа
        // 

        Log.Information("Application stop!");
        Log.CloseAndFlush();
    }
}