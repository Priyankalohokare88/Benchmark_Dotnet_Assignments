using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2.Models;

namespace Project2.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index(string SortColumn="Depname",string IconClass="fa-sort-asc")
        {

            EmpDep1Entities db = new EmpDep1Entities();
            
List<Department> dep = db.Departments.ToList();
            ViewBag.SortColumn=SortColumn;
            ViewBag.IconClass=IconClass;
            if (ViewBag.SortColumn == "Depid")
            {
                if (ViewBag.IconClass == "fa-sort-asc")
                    dep = dep.OrderBy(temp => temp.Depid).ToList();

                else
                    dep = dep.OrderByDescending(temp => temp.Depid).ToList();
            }
            else if (ViewBag.SortColumn == "Depname")
            {
                if (ViewBag.IconClass == "fa-sort-asc")
                    dep = dep.OrderBy(temp => temp.Depname).ToList();

                else
                    dep = dep.OrderByDescending(temp => temp.Depname).ToList();
            }
            if (ViewBag.SortColumn == "DepLocation")
            {
                if (ViewBag.IconClass == "fa-sort-asc")
                    dep = dep.OrderBy(temp => temp.DepLocation).ToList();

                else
                    dep = dep.OrderByDescending(temp => temp.DepLocation).ToList();
            }
            return View(dep);

        }

        public ActionResult Details(int id)
        {
            EmpDep1Entities db = new EmpDep1Entities();
            Department departments = db.Departments.Where(temp => temp.Depid == id).FirstOrDefault();
            return View(departments);
        }
        public ActionResult Create()
        {

            EmpDep1Entities db = new EmpDep1Entities();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Department d)
        {

            EmpDep1Entities db = new EmpDep1Entities();

            db.Departments.Add(d);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {

            EmpDep1Entities db = new EmpDep1Entities();
      
            Department exp = db.Departments.Where(temp => temp.Depid == id).FirstOrDefault();
            return View(exp);
        }
        [HttpPost]
        public ActionResult Edit(Department d)
        {
            EmpDep1Entities db = new EmpDep1Entities();

            Department exp = db.Departments.Where(temp => temp.Depid == d.Depid).FirstOrDefault();
            exp.Depname = d.Depname;
            exp.DepLocation = d.DepLocation;
            
            db.SaveChanges();
            return RedirectToAction("Index");


        }
        public ActionResult Delete(int id)
        {
            EmpDep1Entities db = new EmpDep1Entities();

            Department exp = db.Departments.Where(temp => temp.Depid == id).FirstOrDefault();
            db.Departments.Remove(exp);

            db.SaveChanges();
            return RedirectToAction("Index");


        }



        [HttpPost]
        //we are passing product p dumy bcz we have already mehod delete to make this method diff we pass product p
        public ActionResult Delete(int id, Department d)
        {

            EmpDep1Entities db = new EmpDep1Entities();

            Department exp = db.Departments.Where(temp => temp.Depid == id).FirstOrDefault();
            db.Departments.Remove(exp);
            db.SaveChanges();
           
            return RedirectToAction("Index");
        }
    //    public ActionResult Search(Department d, string SortColumn = "Depname", string IconClass = "fa-sort-asc")
    //    {

    //        EmpDep1Entities db = new EmpDep1Entities();
    //        ViewBag.s = d;
    //        //List<Department> dep = db.Departments.Where(temp => temp.Depname.Contains(d.Depname)||
    //        //temp.Depname.Contains(null)&& 
    //        //temp.DepLocation.Contains(d.DepLocation)).ToList();
    //        //List<Department> dep = db.Departments.ToList();
    //        //if (d.Depname != null && d.DepLocation != null&& d.Depid!=0) 
    //        //{
    //        //    List<Department> dep = db.Departments.Where(temp => temp.Depname.Contains(d.Depname)
    //        //    && temp.DepLocation.Contains(d.DepLocation)).ToList();
    //        //    return View(dep);
    //        //}


    //        //List<Department> dep = db.Departments.WhereIf(temp => temp.Depname.Contains(d.Depname)
    //        // || temp.DepLocation.Contains(d.DepLocation)).ToList();


    //        List<Department> dep = db.Departments
    //.Where( s => s.Depname == d.Depname||d.Depname==null)
    //.Where(s => s.DepLocation == d.DepLocation || d.DepLocation == null)
    //.ToList();
    //        return View(dep);
    //        }
            


        }

    }
