using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        private ProductsDATA _Products = new ProductsDATA();

        public ActionResult Index()
        {

            var Products = new ProductsDATA();
            return View(Products.GetList());
        }
        public ActionResult Create()
        {
            return View(new Products());
        }
        [HttpPost]
        public ActionResult Create(Products Products)
        {
            if (ModelState.IsValid)
            {
                _Products.Add(Products);
                return RedirectToAction("Index");
            }
            return View();
        }



        public ActionResult Edit(int id)
        {
            var Products = _Products.GetProducts(id);
            if (Products == null)
                RedirectToAction("Index");

            return View(Products);

        }
        [HttpPost]
        public ActionResult Edit(Products Products)

        {

            if (_Products.update(Products) > 0)
                return RedirectToAction("Index");
            return View(Products);
        }



        public ActionResult Delete(int id)
        {

            var Products = _Products.GetProducts(id);
            if (Products == null)
                RedirectToAction("Index");

            return View(Products);
        }
        [HttpPost]
        public ActionResult Delete(Products Products)
        {
            if (_Products.Delete(Products) > 0)
                return RedirectToAction("Index");

            return View(Products);
        }
    }
}