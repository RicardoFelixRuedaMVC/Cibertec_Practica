using System.Linq;
using WebDeveloper.Model;
namespace WebDeveloper.DataAccess
{
  public class OrdersDATA:BaseDataAccess<Orders>
    {
        public Orders GetOrders(int id)
        {

            using (var dbcontext = new WebContextDB())
                return dbcontext.Orders.FirstOrDefault(x => x.OrderID == id);

        }

    }
}
