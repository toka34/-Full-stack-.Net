using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_08
{
    public interface ILogger
    {
        // Default implementation of Log method
        void Log()
        {
            Console.WriteLine("Default log message from ILogger.");
        }
    }
}
