using EmployeeApp.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Configuration;
using System.Web.Mvc;
using EmployeeApp.Models;
namespace EmployeeApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            using (var ctx = new EmployeeContext())
            {
                
                var dbemployees = ctx.Employees.Take(10).ToList();
                var employeeModel = new List<EmployeeModel>();
                foreach (var dbEmployee in dbemployees) {
                 //   var fname = dbEmployee.FirstName + " " + dbEmployee.LastName;
                    employeeModel.Add(new EmployeeModel()
                    {
                       Address = dbEmployee.Address,
                        FirstName = dbEmployee.FirstName,
                        LastName =dbEmployee.LastName,
                        PhoneNumber = dbEmployee.PhoneNumber,
                        EmailAddress = dbEmployee.EmailAddress,
                        Comments = dbEmployee.Comments
                    }); }
                return View(employeeModel);
            }          
            
        }


        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
