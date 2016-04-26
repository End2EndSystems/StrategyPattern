using StrategyPattern.Roles;
using StrategyPattern.Resources;

using System;
using StrategyPattern.Util;
using System.Resources;

namespace StrategyPattern
{
    class Sale
    {

        //atributos e construtor
        public IRole Role { get; set; }
        public double Value { get; set; }
        public double Commission { get; set; }

        private ResourceManager Resource;

        public Sale(int roleType, double value) {
            Resource = StringsRes.ResourceManager;
            Role = RoleFactory.CreateRole(roleType);
            Value = value;
            calcCommision();
        }

        public void calcCommision()
        {
            Commission = Role.GetCommission(Value);
            var str = String.Format("{0} = {1}",
                Resource.GetString(Role.GetType().Name),
                Commission);
            Logger.Log(str);
        }
    }
}
