using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{ 
public class WebContextDB: DbContext
    {

        public WebContextDB(): base ("name=WebDeveloperConnectionString")
        {
           Database.SetInitializer(new WebDeveloperInitializer());
        }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }



    }
}
