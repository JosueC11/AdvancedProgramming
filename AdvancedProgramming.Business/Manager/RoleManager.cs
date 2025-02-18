using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdvancedProgramming.Data;
using AdvancedProgramming.Repository.Implementation;
using AdvancedProgramming.Repository.Interface;

namespace AdvancedProgramming.Business.Manager
{
    public class RoleManager
    {
        private readonly IRoleRepository _repository = new RoleRepository();
        public void Add(Role entity)
        {
            _repository.Add(entity);
        }
        public void DeleteById(int id)
        {
            _repository.DeleteById(id);
        }
        public IEnumerable<Role> GetAll()
        {
            return _repository.GetAll();
        }
        public Role GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Update(Role entity)
        {
            _repository.Update(entity);
        }
    }
}
