using System;

using SingleResponsibilityPrinciple.Contracts;
using System.IO;

namespace SingleResponsibilityPrinciple
{
    public class ConsoleLogger : ILogger
    {
        public void LogWarning(string message, params object[] args)
        {
            var type = "WARN";
            Console.WriteLine(string.Concat(type+": ", message), args);
            using (StreamWriter logfile = File.AppendText("log.xml"))
            {
                logfile.WriteLine("<log><type>" + type + "</type><message>" + message + "</message></log>", args);
            }
        }

        public void LogInfo(string message, params object[] args)
        {
            var type = "INFO";
            Console.WriteLine(string.Concat(type+": ", message), args);
            using (StreamWriter logfile = File.AppendText("log.xml"))
            {
                logfile.WriteLine("<log><type>" + type + "</type><message>" + message + "</message></log>", args);
            }
         }
    }
}
