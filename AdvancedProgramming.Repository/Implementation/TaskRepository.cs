using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdvancedProgramming.Data;
using AdvancedProgramming.Repository.Interface;

namespace AdvancedProgramming.Repository.Implementation
{
    public class TaskRepository : BaseRepository<Task>, ITaskRepository
    {
        public TaskRepository() : base() { }
    }
}
