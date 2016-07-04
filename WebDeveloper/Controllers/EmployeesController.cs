using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;
namespace WebDeveloper.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        private EmployeesDATA _Employees = new EmployeesDATA();

        public ActionResult Index()
        {
            var Employees = new EmployeesDATA();
            return View(Employees.GetList());
        }
        public ActionResult Create()
        {
            return View(new Employees());
        }
        [HttpPost]
        public ActionResult Create(Employees Employees)
        {
            if (ModelState.IsValid)
            {
                _Employees.Add(Employees);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            var Employees = _Employees.GetEmployees(id);
            if (Employees == null)
                RedirectToAction("Index");
            return View(Employees);
        }
        [HttpPost]
        public ActionResult Edit(Employees Employees)

        {
            if (_Employees.update(Employees) > 0)
                return RedirectToAction("Index");
            return View(Employees);
        }
        public ActionResult Delete(int id)
        {

            var Employees = _Employees.GetEmployees(id);
            if (Employees == null)
                RedirectToAction("Index");
            return View(Employees);
        }
        [HttpPost]
        public ActionResult Delete(Employees Employees)
        {
            if (_Employees.Delete(Employees) > 0)
                return RedirectToAction("Index");
            return View(Employees);
        }
    }
}