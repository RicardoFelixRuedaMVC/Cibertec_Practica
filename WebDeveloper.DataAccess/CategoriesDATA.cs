using System.Linq;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class CategoriesDATA:BaseDataAccess<Categories>
    {
        public Categories GetCategories(int id)
        {

            using (var dbcontext = new WebContextDB())
            return dbcontext.Categories.FirstOrDefault(x => x.CategoryID == id);

        }

    }
}
