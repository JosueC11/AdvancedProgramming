using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AdvancedProgramming.Business.Manager;
using AdvancedProgramming.Data;

namespace AdvancedProgramming.Controllers
{
    public class UserRolesController : Controller
    {
        private readonly UserRoleManager _manager = new UserRoleManager();
        private readonly RoleManager _managerRole = new RoleManager();
        private readonly UserManager _managerUser = new UserManager();

        // GET: UserRoles
        public ActionResult Index()
        {
            var userRoles = _manager.GetAll().ToList();
            return View(userRoles);
        }

        // GET: UserRoles/Details/5
        public ActionResult Details(int? id1, int? id2)
        {
            if (id1 == null || id2 == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var userRole = _manager.GetByIdCombinated((int)id1, (int)id2);
            if (userRole == null)
            {
                return HttpNotFound();
            }
            return View(userRole);
        }

        // GET: UserRoles/Create
        public ActionResult Create()
        {
            ViewBag.RoleID = new SelectList(_managerRole.GetAll().ToList(), "RoleID", "RoleName");
            ViewBag.UserID = new SelectList(_managerUser.GetAll().ToList(), "UserID", "Username");
            return View();
        }

        // POST: UserRoles/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserID,RoleID,AssignedAt")] UserRole userRole)
        {
            var userRoleSearch = _manager.GetByIdCombinated((int)userRole.RoleID, (int)userRole.UserID);

            if (userRoleSearch == null) 
            {
                if (ModelState.IsValid)
                {
                    _manager.Add(userRole);
                    return RedirectToAction("Index");
                }

                ViewBag.RoleID = new SelectList(_managerRole.GetAll().ToList(), "RoleID", "RoleName");
                ViewBag.UserID = new SelectList(_managerUser.GetAll().ToList(), "UserID", "Username");
                return View(userRole);
            }

            ViewBag.RoleID = new SelectList(_managerRole.GetAll().ToList(), "RoleID", "RoleName");
            ViewBag.UserID = new SelectList(_managerUser.GetAll().ToList(), "UserID", "Username");
            return View(userRole);
        }

        // GET: UserRoles/Edit/5
        public ActionResult Edit(int? id1, int? id2)
        {
            if (id1 == null || id2 == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var userRole = _manager.GetByIdCombinated((int)id1, (int)id2);
            if (userRole == null)
            {
                return HttpNotFound();
            }
            ViewBag.RoleID = new SelectList(_managerRole.GetAll().ToList(), "RoleID", "RoleName");
            ViewBag.UserID = new SelectList(_managerUser.GetAll().ToList(), "UserID", "Username");
            return View(userRole);
        }

        // POST: UserRoles/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserID,RoleID,AssignedAt")] UserRole userRole)
        {
            if (ModelState.IsValid)
            {
                _manager.Update(userRole);
                return RedirectToAction("Index");
            }
            ViewBag.RoleID = new SelectList(_managerRole.GetAll().ToList(), "RoleID", "RoleName");
            ViewBag.UserID = new SelectList(_managerUser.GetAll().ToList(), "UserID", "Username");
            return View(userRole);
        }

        // GET: UserRoles/Delete/5
        public ActionResult Delete(int? id1, int? id2)
        {
            if (id1 == null || id2 == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var userRole = _manager.GetByIdCombinated((int)id1, (int)id2);
            if (userRole == null)
            {
                return HttpNotFound();
            }
            return View(userRole);
        }

        // POST: UserRoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id1, int? id2)
        {
            var userRole = _manager.GetByIdCombinated((int)id1, (int)id2);
            _manager.DeleteEntity(userRole);
            return RedirectToAction("Index");
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
