
using System.Linq;
using WebDeveloper.Model;
namespace WebDeveloper.DataAccess
{
   public class CustomersDATA:BaseDataAccess<Customers>
    {
        public Customers GetCategories(string id)
        {

            using (var dbcontext = new WebContextDB())
                return dbcontext.Customers.FirstOrDefault(x => x.CustomerID == id);

        }


    }
}
