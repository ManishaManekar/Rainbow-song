using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee() {EmpId=1, EmpName="ABC", EmpSalary=10000 });
            list.Add(new Employee() { EmpId = 2, EmpName = "XYZ", EmpSalary = 16000 });
            list.Add(new Employee() { EmpId = 3, EmpName = "PQR", EmpSalary = 12000 });
            list.Add(new Employee() { EmpId = 4, EmpName = "LMN", EmpSalary = 14000 });
            ViewBag.Employees = list;
            return View();
        }
    }
}