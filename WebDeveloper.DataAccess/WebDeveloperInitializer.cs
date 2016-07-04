using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
  public class WebDeveloperInitializer: DropCreateDatabaseAlways<WebContextDB>
    {
        protected override void Seed(WebContextDB context)
        {
            var categories = new List<Categories>
            {
                new Categories {CategoryName="Mouse", Description="interfaz manual", Picture=null},
                new Categories {CategoryName="Monitor", Description="interfaz manual", Picture=null}

            };

            categories.ForEach(c => context.Categories.Add(c));
            context.SaveChanges();

            //var customers = new List<Customers>
            //{
            //    new Customers { CompanyName="Metro", City="Lima", Country="Peru", Region="Lima", Address="San Borja", PostalCode="Lima 18", ContactName="Alfredo perez", ContactTitle="Ingeniers", Phone="973845909", Fax="2243274" }
            //  };

            //customers.ForEach(c => context.Customers.Add(c));
            //context.SaveChanges();


       }
 
     }
 }
