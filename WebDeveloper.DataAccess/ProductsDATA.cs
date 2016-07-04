using System.Linq;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
  public class ProductsDATA:BaseDataAccess<Products>
    {
        public Products GetCategories(int id)
        {

            using (var dbcontext = new WebContextDB())
                return dbcontext.Products.FirstOrDefault(x => x.ProductID == id);

        }

    }
}
