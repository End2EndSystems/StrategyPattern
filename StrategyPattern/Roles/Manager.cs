using StrategyPattern.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Roles
{
    class Manager : IRole
    {
        public double GetCommission(double value)
        {
            Console.Write(StringsRes.Commission + ": 20% + 10");
            return value * 0.20 + 10;
        }
    }
}
