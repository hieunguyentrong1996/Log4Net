using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Log4Net
{
    class Program
    {
        // Declare an instance for log4net
        private static readonly ILog Log4Net = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            ImplementLoggingFunction();
        }

        private static void ImplementLoggingFunction()
        {
            /*
             FATAL
             ERROR
             WARN
             INFO
             DEBUG
             */
            var secs = 3;
            Log4Net.Fatal("Start log Fatal");
            Console.WriteLine("Start log Fatal");

            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep 3 secs
            Log4Net.Error("Start log Error...");
            Console.WriteLine("Start log Error...");

            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep 3 secs
            Log4Net.Warn("Start log Warn...");
            Console.WriteLine("Start log Warn...");

            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep 3 secs
            Log4Net.Info("Start log Info...");
            Console.WriteLine("Start log Info...");

            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep 3 secs
            Log4Net.Debug("Start log Debug...");
            Console.WriteLine("Start log Debug...");

            Console.ReadKey();
        }


    }
}
