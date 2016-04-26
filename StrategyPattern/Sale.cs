using StrategyPattern.Roles;
using StrategyPattern.Resources;

using System;

namespace StrategyPattern
{
    class Sale
    {

        //atributos e construtor
        public IRole Role { get; set; }
        public double Value { get; set; }

        public Sale() { }

        public double getCommission()
        {
            string desc = String.Empty;
            double commission = 0.0;
            Type type;

            type = Role.GetType();
            desc = StringsRes.ResourceManager.GetString(type.Name);
            commission = Role.GetCommission(Value);

            Console.WriteLine(desc);

            return commission;
        }
    }
}
