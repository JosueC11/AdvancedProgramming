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
    public class UserManager
    {
        private readonly IUserRepository _repository = new UserRepository();
        public void Add(User entity)
        {
            _repository.Add(entity);
        }
        public void DeleteById(int id)
        {
            _repository.DeleteById(id);
        }
        public IEnumerable<User> GetAll()
        {
            return _repository.GetAll();
        }
        public User GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Update(User entity)
        {
            _repository.Update(entity);
        }
    }
}
