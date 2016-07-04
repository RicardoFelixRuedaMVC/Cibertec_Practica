using System.Linq;
using WebDeveloper.Model;
namespace WebDeveloper.DataAccess
{
    class OrdersDATA:BaseDataAccess<Orders>
    {
        public Orders GetCategories(int id)
        {

            using (var dbcontext = new WebContextDB())
                return dbcontext.Orders.FirstOrDefault(x => x.OrderID == id);

        }

    }
}
