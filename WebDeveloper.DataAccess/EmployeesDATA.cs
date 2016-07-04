using System.Linq;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class EmployeesDATA:BaseDataAccess<Employees>
    {
        public Employees GetCategories(int id)
        {

            using (var dbcontext = new WebContextDB())
                return dbcontext.Employees.FirstOrDefault(x => x.EmployeeID == id);

        }


    }
}
