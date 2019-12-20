using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly ProjectDbContext _db = new ProjectDbContext();

        public ActionResult Index()
        {
            List<Department> departments = _db.Departments.ToList();

            return View(departments);
        }


        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult Create(Department department)
        {
            if (ModelState.IsValid)
            {
                List<Department> existDep = _db.Departments.ToList();
                var matchingDep=existDep.Where(m => m.Name == department.Name || m.Code == department.Code);
                if(matchingDep.Any())
                {
                    TempData["error"]= "Name or Code Already Exist.";
                    return View(department);
                }      
                
                _db.Departments.Add(department);
                if (_db.SaveChanges()>0)
                {
                    TempData["Success"] = "Data Successfully Saved.";
                }
                ;
                
                return RedirectToAction("Index");
            }

            return View(department);
        }

        
        public ActionResult Delete(int id)
        {
            var dep = _db.Departments.Find(id);
            if (dep != null)
            {
                _db.Departments.Remove(dep);
            }

            if (_db.SaveChanges() > 0)
            {   
                TempData["error"]= "Deleted Successfully";
            }
            return RedirectToAction("Index");
        }
        
    }
}
