using System.Collections.Generic;
using System.Linq;
using WebDeveloper.Model;
using System;
namespace WebDeveloper.DataAccess
{
    public class CategoriesDATA : BaseDataAccess<Categories>
    {
        public Categories GetCategories(int id)
        {

            using (var dbcontext = new WebContextDB())
                return dbcontext.Categories.FirstOrDefault(x => x.CategoryID == id);

        }
        public List<Categories> GetFakeCategories()
        {
            return new List<Categories>
            {
                new Categories {CategoryName="Computadoras", Description="Computadoras personales" },
                new Categories {CategoryName="impresoras", Description="Laser" }

            };
        }
        public Categories GetCategoriesRazor(Categories categories)
        {
            return categories;
        }
    }
}
