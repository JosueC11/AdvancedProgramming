using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdvancedProgramming.Data;
using AdvancedProgramming.Repository.Implementation;
using AdvancedProgramming.Repository.Interface;

namespace AdvancedProgramming.Business.Manager
{
    public class TaskManager
    {
        private readonly ITaskRepository _repository = new TaskRepository();
        public void Add(Task entity)
        {
            _repository.Add(entity);
        }
        public void DeleteById(int id)
        {
            _repository.DeleteById(id);
        }
        public IEnumerable<Task> GetAll()
        {
            return _repository.GetAll();
        }
        public Task GetById(int id)
        {
            return _repository.GetById(id);
        }
        public void Update(Task entity)
        {
            _repository.Update(entity);
        }
    }
}
