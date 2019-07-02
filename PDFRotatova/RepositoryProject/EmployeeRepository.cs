using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelProject;

namespace RepositoryProject
{
   public  class EmployeeRepository:IEmployeeRepostory
    {
        public IEnumerable<EmployeeModel> GetEmployees()
        {
            var dbcntxt = new EmployeeDBContext();
            var lstemployee = dbcntxt.Employees;
            return lstemployee.ToList();
        }
    }
}
