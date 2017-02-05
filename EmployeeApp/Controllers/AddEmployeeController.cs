using EmployeeApp.Models;
using EmployeeApp.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeApp.Controllers
{
    public class AddEmployeeController : Controller
    {

        // GET: AddEmployee/Add
        public ActionResult Add()
        {
            return View(new EmployeeModel {EmailAddress="test@test.com" });
        }

        // POST: AddEmployee/Add
        [ValidateInput(true)]
        [HttpPost]
        public ActionResult Add(EmployeeModel employee)
        {
            if (ModelState.IsValid)
            {
                //Entity FrameWork Code
                //var ctx = new EmployeeContext();

                //ctx.Employees.Add(new Employee()
                //{
                //    FirstName = employee.FirstName,
                //    LastName = employee.LastName,
                //    Address = employee.Address,
                //    PhoneNumber = employee.PhoneNumber,
                //    EmailAddress = employee.EmailAddress,
                //    Comments = employee.Comments

                //}
                //    );

                //ctx.SaveChanges();

                // ADO.Net Code
                new AddEmployeeDB().InsertEmployee(new AddEmployeeDB()
                {
                    Address = employee.Address,
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    PhoneNumber = employee.PhoneNumber,
                    EmailAddress = employee.EmailAddress,
                    Comments = employee.Comments

                });
                return RedirectToAction("Index","Home");
            }

            return View(employee);
            }

        }
}
