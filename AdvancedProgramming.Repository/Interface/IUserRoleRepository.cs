using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedProgramming.Data;

namespace AdvancedProgramming.Repository.Interface
{
    public interface IUserRoleRepository : IBaseRepository<UserRole>
    {
        UserRole GetByIdCombinated(int id1, int id2);
        void DeleteEntity(UserRole entity);
    }
}
