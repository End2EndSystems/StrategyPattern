using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Util
{
    public static class Logger
    {
        public static void Log(string msg, bool newLine = false)
        {
            if (newLine)
            {
                Console.WriteLine(msg);
                return;
            }

            Console.Write(msg);
        }
    }
}
