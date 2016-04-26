using StrategyPattern.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Roles
{
    public class Attentant : IRole
    {
        public double GetCommission(double value)
        {
            Console.WriteLine(StringsRes.Commission + ": 10%");
            return value * 0.1;
        }
    }
}
