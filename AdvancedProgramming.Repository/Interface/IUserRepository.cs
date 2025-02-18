using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedProgramming.Data;
using AdvancedProgramming.Repository.Implementation;

namespace AdvancedProgramming.Repository.Interface
{
    public interface IUserRepository : IBaseRepository<User>
    {
    }
}
