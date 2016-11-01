using Data.Models;
using Domain;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace WebApplication11.Controllers
{
    public class UsersController : Controller

    {

        IEmployeeService emservice;
        public UsersController(IEmployeeService emservice)
        {
            this.emservice = emservice;
        }

        
             // GET: Users
        private ApplicationUserManager _userManager;
        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }
        private ApplicationRoleManager _roleManager;
        public ApplicationRoleManager RoleManager
        {
            get
            {
                return _roleManager ?? HttpContext.GetOwinContext().Get<ApplicationRoleManager>();
            }
            private set
            {
                _roleManager = value;
            }
        }

        public ActionResult Index()
        {
            return View();
        }

        // GET: Users/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        [Authorize(Roles = "HR Manager")]
        public async System.Threading.Tasks.Task<ActionResult> Create(employee e)
        {
            if (ModelState.IsValid)
            {
                var user = new User { UserName = e.email, Email = e.email };

                var adminresult = await UserManager.CreateAsync(user, "Erp-bank!111");

                employee test = new employee(user.Id, e.email, "Erp-bank!111", e.userName, e.name, e.lastName,e.role);
                emservice.AddEmployee(test);
                if (adminresult.Succeeded)
                {
                    await UserManager.AddToRolesAsync(user.Id, e.role);
                }
            }
            return View("Create");
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Users/Edit/5
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

        // GET: Users/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Users/Delete/5
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
