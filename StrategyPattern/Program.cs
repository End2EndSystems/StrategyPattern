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
            int entry = -1;

            do
            {
                Init();

                int.TryParse(Console.ReadLine(), out entry);

                if (entry == 0)
                {
                    Console.Write(StringsRes.Exiting);
                    Thread.Sleep(TimeSpan.FromSeconds(2));
                    return;
                }

                Execute(entry);

            } while (entry != 0);
        }

        private static void Init()
        {
            Console.Clear();
            Console.WriteLine("Available roles:");
            
            foreach (RolesEnum role in Roles)
            {
                Console.WriteLine("{0:d}: {1}",
                    role,
                    Res.GetString(role.ToString()));
            }

            Console.Write("Role: ");
        }

        private static void Execute(int roleType)
        {
            double value = 0.0;

            try
            {
                Logger.Log(StringsRes.SaleValue);

                double.TryParse(Console.ReadLine(), out value);
                new Sale(roleType, value);
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
