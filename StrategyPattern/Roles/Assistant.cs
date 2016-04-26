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
            Console.WriteLine("{0}: 8% + 1", StringsRes.Commission);
            return value * 0.08 + 1;
        }
    }
}
