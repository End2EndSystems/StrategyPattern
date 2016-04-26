using StrategyPattern.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Roles
{
    class Salesman : IRole
    {
        public double GetCommission(double value)
        {
            Console.Write(StringsRes.Commission + ": 15% + 5");
            return value * 0.15 + 5;
        }
    }
}
