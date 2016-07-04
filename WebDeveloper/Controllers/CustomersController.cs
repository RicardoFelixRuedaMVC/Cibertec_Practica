using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;
namespace WebDeveloper.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        private CustomersDATA _Customers = new CustomersDATA();
   
        public ActionResult Index()
        {

            var Customers = new CustomersDATA();
            return View(Customers.GetList());
        }

        public ActionResult Create()
        {
            return View(new Customers());
        }
        [HttpPost]
        public ActionResult Create(Customers Customers)
        {
            if (ModelState.IsValid)
            {
                _Customers.Add(Customers);
                return RedirectToAction("Index");
            }
            return View();
        }



        public ActionResult Edit(int id)
        {
            var Customers = _Customers.GetCustomers(id);
            if (Customers == null)
                RedirectToAction("Index");

            return View(Customers);

        }
        [HttpPost]
        public ActionResult Edit(Customers Customers)

        {

            if (_Customers.update(Customers) > 0)
                return RedirectToAction("Index");
            return View(Customers);
        }



        public ActionResult Delete(int id)
        {

            var Customers = _Customers.GetCustomers(id);
            if (Customers == null)
                RedirectToAction("Index");

            return View(Customers);
        }
        [HttpPost]
        public ActionResult Delete(Customers Customers)
        {
            if (_Customers.Delete(Customers) > 0)
                return RedirectToAction("Index");

            return View(Customers);
        }
    }
}