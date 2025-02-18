using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedProgramming.Repository.Interface;
using AdvancedProgramming.Repository.Implementation;
using AdvancedProgramming.Data;
using System.Runtime.Remoting.Contexts;

namespace AdvancedProgramming.Business.Manager
{
    public class ProductManager
    {
        private readonly IProductRepository _repository = new ProductRepository();
        public void Add(Product entity)
        {
            _repository.Add(entity);
        }   
        public void DeleteById(int id)
        {
            _repository.DeleteById(id);
        }
        public IEnumerable<Product> GetAll()
        {
            return _repository.GetAll();
        }
        public Product GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Update(Product entity)
        {
            _repository.Update(entity);
        }
    }
}
