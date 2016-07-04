using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
namespace WebDeveloper.DataAccess
{
    public class BaseDataAccess<T> : IDataAccess<T> where T : class
    {
        public int Add(T entity)
        {
            using (var dbContext = new WebContextDB())
            {

                dbContext.Entry(entity).State = EntityState.Added;
                return dbContext.SaveChanges();
            }

        }

        public int Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> GetList()
        {
            throw new NotImplementedException();
        }

        public int update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
