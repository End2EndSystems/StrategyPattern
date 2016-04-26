using StrategyPattern.Resources;
using StrategyPattern.Roles;
using StrategyPattern.Util;
using System;
using System.Collections.Generic;
using System.Resources;
using System.Threading;

namespace StrategyPattern
{
    class Program
    {
        #region Properties
        static ResourceManager Res;
        static IEnumerable<RolesEnum> Roles;
        #endregion

        static void Main(string[] args)
        {
            Roles = EnumUtil.GetValues<RolesEnum>();
            Res = StringsRes.ResourceManager;

            new Thread(Run).Start();
        }

        private static void Run()
        {
            string readLine = null;
            int entry = 0;
            do
            {
                Init();

                readLine = Console.ReadLine();

                entry = int.Parse(readLine);

                Execute(entry);

            } while (readLine != "0");
        }

        private static void Init()
        {
            Console.Clear();
            Console.WriteLine("Available roles:");
            
            foreach (RolesEnum role in Roles)
            {
                var description = Res.GetString(role.ToString());
                Console.WriteLine("{0:d}: {1}", role, description);
            }

            Console.Write("Role:");
        }

        private static void Execute(int roleType)
        {
            string readLine = null;
            Sale sale = null;

            if (roleType == 0)
            {
                Console.Write(StringsRes.Exiting);
                return;
            }

            try
            {
                sale = new Sale();

                sale.Role = RoleFactory.CreateRole(roleType);

                Console.Write(StringsRes.SaleValue);
                readLine = Console.ReadLine();
                sale.Value = Double.Parse(readLine);

                Console.Write(" = " + sale.getCommission());
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
