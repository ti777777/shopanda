using Interface.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Web.Models;

namespace DAL.Repository
{
    public class ProductRepository : IRepositoryBase<Product>
    {
        public shopContext DbContext { get; set; }
        public ProductRepository(shopContext db)
        {
            DbContext = db;
        }
        public void Create(Product entity)
        {
            try
            {
                DbContext.Products.Add(entity);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public void Delete(Product entity)
        {
            try
            {
                DbContext.Products.Remove(entity);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<Product> FindAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> FindByCondition(Expression<Func<Product, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

}
