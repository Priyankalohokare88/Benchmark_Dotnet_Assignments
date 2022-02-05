using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2.Models;

namespace Project2.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index(string SortColumn = "Empname", string IconClass = "fa-sort-asc")
        {

            EmpDep1Entities db=new EmpDep1Entities();
            List<employee> emp = db.employees.ToList();
            ViewBag.SortColumn = SortColumn;
            ViewBag.IconClass = IconClass;
            if (ViewBag.SortColumn == "Empid")
            {
                if (ViewBag.IconClass == "fa-sort-asc")
                    emp = emp.OrderBy(temp => temp.Empid).ToList();

                else
                    emp = emp.OrderByDescending(temp => temp.Empid).ToList();
            }
            else if (ViewBag.SortColumn == "Empname")
            {
                if (ViewBag.IconClass == "fa-sort-asc")
                    emp = emp.OrderBy(temp => temp.Empname).ToList();

                else
                    emp = emp.OrderByDescending(temp => temp.Empname).ToList();
            }
            else if (ViewBag.SortColumn == "Designation")
            {
                if (ViewBag.IconClass == "fa-sort-asc")
                    emp = emp.OrderBy(temp => temp.Designation).ToList();

                else
                    emp = emp.OrderByDescending(temp => temp.Designation).ToList();
            }
            else if (ViewBag.SortColumn == "Mgid")
            {
                if (ViewBag.IconClass == "fa-sort-asc")
                    emp = emp.OrderBy(temp => temp.Mgid).ToList();

                else
                    emp = emp.OrderByDescending(temp => temp.Mgid).ToList();
            }
            else if (ViewBag.SortColumn == "Emailid")
            {
                if (ViewBag.IconClass == "fa-sort-asc")
                    emp = emp.OrderBy(temp => temp.Emailid).ToList();

                else
                    emp = emp.OrderByDescending(temp => temp.Emailid).ToList();
            }
           else if (ViewBag.SortColumn == "Hire_date")
            {
                if (ViewBag.IconClass == "fa-sort-asc")
                    emp = emp.OrderBy(temp => temp.Hire_date).ToList();

                else
                    emp = emp.OrderByDescending(temp => temp.Hire_date).ToList();
            }
            else if (ViewBag.SortColumn == "sal")
            {
                if (ViewBag.IconClass == "fa-sort-asc")
                    emp = emp.OrderBy(temp => temp.sal).ToList();

                else
                    emp = emp.OrderByDescending(temp => temp.sal).ToList();
            }
            else if (ViewBag.SortColumn == "Depid")
            {
                if (ViewBag.IconClass == "fa-sort-asc")
                    emp = emp.OrderBy(temp => temp.Depid).ToList();

                else
                    emp = emp.OrderByDescending(temp => temp.Depid).ToList();
            }
            return View(emp);

        

    }
    public ActionResult Details(int id)
        {
            EmpDep1Entities db = new EmpDep1Entities();
             employee employees = db.employees.Where(temp => temp.Empid == id).FirstOrDefault();
            return View(employees);
        }
        public ActionResult Create()
        {

            EmpDep1Entities db = new EmpDep1Entities();
            ViewBag.dep = db.Departments;
            ViewBag.msg = "New Employee Added Successfully!!";

            return View();
        }
        [HttpPost]
        public ActionResult Create(employee e)
        {

            EmpDep1Entities db = new EmpDep1Entities();

            db.employees.Add(e);
            db.SaveChanges();
            ViewBag.msg = "New Employee Added Successfully!!";
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {

            EmpDep1Entities db = new EmpDep1Entities();


            ViewBag.dep = db.Departments;
          
            employee exp = db.employees.Where(temp => temp.Empid == id).FirstOrDefault();
            return View(exp);
        }
        [HttpPost]
        public ActionResult Edit(employee e)
        {
            EmpDep1Entities db = new EmpDep1Entities();
            employee exp = db.employees.Where(temp => temp.Empid == e.Empid).FirstOrDefault();
            exp.Empname = e.Empname;
            exp.Designation=e.Designation;
            exp.Mgid = e.Mgid;
            exp.Emailid=e.Emailid;
            exp.Hire_date = e.Hire_date;
            exp.sal=e.sal;
            exp.Depid=e.Depid;
            db.SaveChanges();
            return RedirectToAction("Index");


        }
        public ActionResult Search(employee e)
        {

            EmpDep1Entities db = new EmpDep1Entities();
            ViewBag.s = e;
            List<employee> emp = db.employees
           .Where(s => s.Empname.Contains(e.Empname) || e.Empname == null)
           .Where(s => s.Designation.Contains(e.Designation)||e.Designation==null)
           .Where(s=>s.Mgid== e.Mgid||e.Mgid==null)
           .Where(s=>s.Depid== e.Depid || e.Depid==null)
           .Where(s => s.Depid == e.Depid || e.Depid ==null)




           .ToList();
            ViewBag.dep = db.Departments;

            return View(emp);
        }

     
        //we are passing product p dumy bcz we have already mehod delete to make this method diff we pass product p
        public ActionResult Delete(int id, employee d)
        {

            EmpDep1Entities db = new EmpDep1Entities();

            employee exp = db.employees.Where(temp => temp.Empid == id).FirstOrDefault();
            db.employees.Remove(exp);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
            