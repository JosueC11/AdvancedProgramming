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
    public class ProductsController : Controller
    {
        private readonly ProductManager _manager = new ProductManager();
        private readonly CategoryManager _managerCategory = new CategoryManager();
        private readonly SupplierManager _managerSupplier = new SupplierManager();

        // GET: Products
        public ActionResult Index()
        {
            var products = _manager.GetAll().ToList();
            return View(products);
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var product = _manager.GetById((int)id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(_managerCategory.GetAll().ToList(), "CategoryID", "CategoryName");
            ViewBag.SupplierID = new SelectList(_managerSupplier.GetAll().ToList(), "SupplierID", "SupplierName");
            return View();
        }

        // POST: Products/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductID,ProductName,SupplierID,CategoryID,UnitPrice,QuantityPerUnit,UnitsInStock")] Product product)
        {
            if (ModelState.IsValid)
            {
                _manager.Add(product);
                return RedirectToAction("Index");
            }

            ViewBag.CategoryID = new SelectList(_managerCategory.GetAll().ToList(), "CategoryID", "CategoryName");
            ViewBag.SupplierID = new SelectList(_managerSupplier.GetAll().ToList(), "SupplierID", "SupplierName");
            return View(product);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var product = _manager.GetById((int)id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryID = new SelectList(_managerCategory.GetAll().ToList(), "CategoryID", "CategoryName");
            ViewBag.SupplierID = new SelectList(_managerSupplier.GetAll().ToList(), "SupplierID", "SupplierName");
            return View(product);
        }

        // POST: Products/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductID,ProductName,SupplierID,CategoryID,UnitPrice,QuantityPerUnit,UnitsInStock")] Product product)
        {
            if (ModelState.IsValid)
            {
                _manager.Update(product);
                return RedirectToAction("Index");
            }
            ViewBag.CategoryID = new SelectList(_managerCategory.GetAll().ToList(), "CategoryID", "CategoryName");
            ViewBag.SupplierID = new SelectList(_managerSupplier.GetAll().ToList(), "SupplierID", "SupplierName");
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var product = _manager.GetById((int)id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id)
        {
            _manager.DeleteById((int)id);
            return RedirectToAction("Index");
        }

        //    protected override void Dispose(bool disposing)
        //    {
        //        if (disposing)
        //        {
        //            db.Dispose();
        //        }
        //        base.Dispose(disposing);
        //    }
    }
}
