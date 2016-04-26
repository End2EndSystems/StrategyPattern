using StrategyPattern.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Roles
{
    class Assistant : IRole
    {
        public double GetCommission(double value)
        {
            Console.Write(StringsRes.Commission + ": 8% + 1");
            return value * 0.08 + 1;
        }
    }
}
