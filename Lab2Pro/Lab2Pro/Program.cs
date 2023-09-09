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

        Log.Debug("Application start!");

        // Работа
        // 

        Log.Debug("Application stop!");
        Log.CloseAndFlush();
    }
}