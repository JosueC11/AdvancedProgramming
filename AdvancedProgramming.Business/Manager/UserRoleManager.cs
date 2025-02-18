using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedProgramming.Data;
using AdvancedProgramming.Repository.Implementation;
using AdvancedProgramming.Repository.Interface;

namespace AdvancedProgramming.Business.Manager
{
    public class UserRoleManager
    {
        private readonly IUserRoleRepository _repository = new UserRoleRepository();
        public void Add(UserRole entity)
        {
            _repository.Add(entity);
        }
        public void DeleteEntity(UserRole entity)
        {
            _repository.DeleteEntity(entity);
        }
        public IEnumerable<UserRole> GetAll()
        {
            return _repository.GetAll();
        }
        public UserRole GetByIdCombinated(int id1, int id2)
        {
            return _repository.GetByIdCombinated(id1, id2);
        }
        public void Update(UserRole entity)
        {
            _repository.Update(entity);
        }
    }
}
