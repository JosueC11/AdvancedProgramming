using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdvancedProgramming.Data;
using AdvancedProgramming.Repository.Implementation;
using AdvancedProgramming.Repository.Interface;

namespace AdvancedProgramming.Business.Manager
{
    public class SupplierManager
    {
        private readonly ISupplierRepository _repository = new SupplierRepository();
        public void Add(Supplier entity)
        {
            _repository.Add(entity);
        }
        public void DeleteById(int id)
        {
            _repository.DeleteById(id);
        }
        public IEnumerable<Supplier> GetAll()
        {
            return _repository.GetAll();
        }
        public Supplier GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Update(Supplier entity)
        {
            _repository.Update(entity);
        }
    }
}
