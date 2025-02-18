using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedProgramming.Data;
using AdvancedProgramming.Repository.Interface;

namespace AdvancedProgramming.Repository.Implementation
{
    public class UserRoleRepository : BaseRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository() : base() { }

        public void DeleteEntity(UserRole entity)
        {
            _context.UserRoles.Remove(entity);
            Save();
        }

        public UserRole GetByIdCombinated(int id1, int id2)
        {
            return _context.UserRoles.FirstOrDefault(e => e.RoleID == id1 && e.UserID == id2);          
        }
    }
}
