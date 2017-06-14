using log4net;
using System;

namespace DemoLog4Net
{
    class Program
    {
        private static readonly ILog loggerLe = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                loggerLe.Info("This is a test message  1 - " + DateTime.UtcNow.Ticks);
                loggerLe.Debug("This is a test message  2 - " + DateTime.UtcNow.Ticks);
                loggerLe.Error("This is a test message  3 - " + DateTime.UtcNow.Ticks);
                loggerLe.Fatal("This is a test message  4 - " + DateTime.UtcNow.Ticks);
                loggerLe.Info("This is a test message  5 - " + DateTime.UtcNow.Ticks);
                loggerLe.Warn("This is a test message  6 - " + DateTime.UtcNow.Ticks);
                loggerLe.Debug("This is a test message  7 - " + DateTime.UtcNow.Ticks);
                loggerLe.Error("This is a test message  8 - " + DateTime.UtcNow.Ticks);
                loggerLe.Fatal("This is a test message  9 - " + DateTime.UtcNow.Ticks);
                Console.WriteLine("Round : " + i);
                System.Threading.Thread.Sleep(2000);
            }
           

            String x = System.Console.ReadLine();

        }
    }
}
