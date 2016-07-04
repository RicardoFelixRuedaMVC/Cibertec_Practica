using System.Web.Mvc;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class RazorController : Controller
    {
        // GET: Razor
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Categories()
        {

            var CategoriesData = new DataAccess.CategoriesDATA();
            return View(CategoriesData.GetFakeCategories());
        }

        public ActionResult Edit(string Name, string description)
        {
            Categories categories = new Categories { CategoryName = Name, Description = description };
                     
            var CategoriesData = new DataAccess.CategoriesDATA();
            return View(CategoriesData.GetCategoriesRazor(categories));
        }

        public ActionResult Delete(string Name, string description)
        {
            Categories categories = new Categories { CategoryName = Name, Description = description };

            var CategoriesData = new DataAccess.CategoriesDATA();
            return View(CategoriesData.GetCategoriesRazor(categories));
        }
    }
}