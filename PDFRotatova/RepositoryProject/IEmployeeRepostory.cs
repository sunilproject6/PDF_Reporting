using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelProject;

namespace RepositoryProject
{
    public interface IEmployeeRepostory
    {
        IEnumerable<EmployeeModel> GetEmployees();
    }
}
