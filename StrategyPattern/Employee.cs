using StrategyPattern.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Employee
    {
        public IRole Role { get; set; }
        public String Name { get; set; }
        public double Salary { get; set; }
    }
}
