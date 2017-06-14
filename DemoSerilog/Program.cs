using Serilog;
using System;

namespace DemoSerilog
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = new LoggerConfiguration().WriteTo.Logentries("b9f852cc-d1e6-49e4-9dee-6752477a309e").CreateLogger();

            for (int i = 0; i < 100; i++)
            {
                log.Debug("Message from Logentries Serilog  1 - " + DateTime.UtcNow.Ticks);
                log.Warning("Message from Logentries Serilog  2 - " + DateTime.UtcNow.Ticks);
                log.Information("Message from Logentries Serilog  4" + DateTime.UtcNow.Ticks);
                log.Write(Serilog.Events.LogEventLevel.Debug, "Message from Logentries Serilog  3 - " + DateTime.UtcNow.Ticks);
                log.Write(Serilog.Events.LogEventLevel.Error, "Message from Logentries Serilog  5 - " + DateTime.UtcNow.Ticks);
                log.Write(Serilog.Events.LogEventLevel.Fatal, "Message from Logentries Serilog  6 - " + DateTime.UtcNow.Ticks);
                log.Write(Serilog.Events.LogEventLevel.Information, "Message from Logentries Serilog  7 - " + DateTime.UtcNow.Ticks);
                log.Write(Serilog.Events.LogEventLevel.Verbose, "Message from Logentries Serilog  8 - " + DateTime.UtcNow.Ticks);
                log.Write(Serilog.Events.LogEventLevel.Warning, "Message from Logentries Serilog  9 - " + DateTime.UtcNow.Ticks);
                Console.WriteLine("round: " + i);
                System.Threading.Thread.Sleep(3000);
            }
            Console.ReadLine();

            (log as IDisposable)?.Dispose();

        }
    }
}
