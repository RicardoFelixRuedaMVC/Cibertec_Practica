using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class CategoriesController : Controller
    {
        private CategoriesDATA _Categories = new CategoriesDATA();
        // GET: Categories
        public ActionResult Index()
        {

            var Categories = new CategoriesDATA();
            return View(Categories.GetList());
        }
        public ActionResult Create()
        {
            return View(new Categories());
        }
        [HttpPost]
        public ActionResult Create(Categories Categories)
        {
            if (ModelState.IsValid)
            {
                _Categories.Add(Categories);
                return RedirectToAction("Index");
            }
            return View();
        }



        public ActionResult Edit(int id)
        {
            var Categories = _Categories.GetCategories(id);
            if (Categories == null)
                RedirectToAction("Index");

            return View(Categories);

        }
        [HttpPost]
        public ActionResult Edit(Categories Categories)

        {

            if (_Categories.update(Categories) > 0)
                return RedirectToAction("Index");
            return View(Categories);
        }



        public ActionResult Delete(int id)
        {

            var Categories = _Categories.GetCategories(id);
            if (Categories == null)
                RedirectToAction("Index");

            return View(Categories);
        }
        [HttpPost]
        public ActionResult Delete(Categories Categories)
        {
            if ( _Categories.Delete(Categories) > 0)
                return RedirectToAction("Index");

            return View(Categories);
        }


    }
}