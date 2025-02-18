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
    public class CategoryManager
    {
        private readonly ICategoryRepository _repository = new CategoryRepository();
        public void Add(Category entity)
        {
            _repository.Add(entity);
        }
        public void DeleteById(int id)
        {
            _repository.DeleteById(id);
        }
        public IEnumerable<Category> GetAll()
        {
            return _repository.GetAll();
        }
        public Category GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Update(Category entity)
        {
            _repository.Update(entity);
        }
    }
}
