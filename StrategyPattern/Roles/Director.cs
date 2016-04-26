using StrategyPattern.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Roles
{
    class Director : IRole
    {
        public double GetCommission(double value)
        {
            Console.WriteLine(StringsRes.Commission + ": 25% + 20");
            return value * 0.25 + 20;
        }
    }
}
