using StrategyPattern.Resources.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Roles
{
    public static class RoleFactory
    {
        #region Properties
        static string RoleNameSpaceFormat;
        #endregion

        public static IRole CreateRole(int roleNumber)
        {
            Type roleType;
            RolesEnum roleEnum;
            string roleNameSpace = null;
            object roleInstance;
            string error = String.Empty;

            try
            {
                error = ErrorRes.NotValidRole;
                roleEnum = (RolesEnum)roleNumber;

                error = ErrorRes.RoleTypeNotFound;
                roleNameSpace = String.Format(RoleNameSpaceFormat, roleEnum);

                roleType = Type.GetType(roleNameSpace);

                error = ErrorRes.UnableToDetermineTheRole;
                roleInstance = Activator.CreateInstance(roleType);

                return (IRole)roleInstance;
            }
            catch (Exception)
            {
                throw new Exception(error);
            }
        }
    }
}
