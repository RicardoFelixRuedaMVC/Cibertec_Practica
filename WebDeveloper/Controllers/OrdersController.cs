using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;
namespace WebDeveloper.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Orders
        private OrdersDATA _Orders = new OrdersDATA();

        public ActionResult Index()
        {

            var Orders = new OrdersDATA();
            return View(Orders.GetList());
        }
        public ActionResult Create()
        {
            return View(new Orders());
        }
        [HttpPost]
        public ActionResult Create(Orders Orders)
        {
            if (ModelState.IsValid)
            {
                _Orders.Add(Orders);
                return RedirectToAction("Index");
            }
            return View();
        }



        public ActionResult Edit(int id)
        {
            var Orders = _Orders.GetOrders(id);
            if (Orders == null)
                RedirectToAction("Index");

            return View(Orders);

        }
        [HttpPost]
        public ActionResult Edit(Orders Orders)

        {

            if (_Orders.update(Orders) > 0)
                return RedirectToAction("Index");
            return View(Orders);
        }



        public ActionResult Delete(int id)
        {

            var Orders = _Orders.GetOrders(id);
            if (Orders == null)
                RedirectToAction("Index");

            return View(Orders);
        }
        [HttpPost]
        public ActionResult Delete(Orders Orders)
        {
            if (_Orders.Delete(Orders) > 0)
                return RedirectToAction("Index");

            return View(Orders);
        }
    }
}