using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelProject;
using System.ComponentModel.DataAnnotations;
using RepositoryProject;
namespace PDFRotatova.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeRepostory _employeeRepository;
        public EmployeeController()
        {
            this._employeeRepository = new EmployeeRepository();
        }

        /// <summary>  
        /// Print Employees details  
        /// </summary>  
        /// <returns></returns>  
        public ActionResult PrintAllEmployee()
        {
            var report = new Rotativa.ActionAsPdf("Employees");
            return report;
        }
        public ActionResult Employees()
        {
            return View(LoadEmployees());
        }

        [NonAction]
        /// <summary>  
        /// Load all Employees  
        /// </summary>  
        /// <returns></returns>  
        private List<EmployeeModel> LoadEmployees()
        {

            return _employeeRepository.GetEmployees().ToList();
        }

        [HttpGet]
        public ActionResult AddEmployee()
        {
            var employee = new EmployeeModel();
            return View(employee);
        }

        [HttpPost]
        public ActionResult AddEmployee(EmployeeModel employee)
        {
            var dbcntxt = new EmployeeDBContext();
            dbcntxt.Employees.Add(employee);
            dbcntxt.SaveChanges();
            return RedirectToAction("Employees");
        }
}
}