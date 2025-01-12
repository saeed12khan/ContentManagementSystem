using Microsoft.AspNet.Identity;
using Nettex.Core.Entities;

namespace Nettex.Service
{
    public class ApplicationRoleService : RoleManager<ApplicationRole>
    {
        #region Ctor

        public ApplicationRoleService(IRoleStore<ApplicationRole> store)
            : base(store)
        {
        }

        #endregion Ctor
    }
}