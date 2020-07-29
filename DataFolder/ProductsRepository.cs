using Microsoft.EntityFrameworkCore;
using Store.Interface;
using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.DataFolder
{
    /// <summary>
    /// Репозитрий товаров
    /// </summary>
    public class ProductsRepository : Irepository<Product>
    {
       StoreContext data;

        public ProductsRepository(StoreContext data)
        {
            this.data = data;
        }
        public void Create(Product item)
        {
            data.Products.Add(item);
        }

        public void Delete(int id)
        {
            var prod = data.Products.Find(id);
            data.Remove(prod);
            data.SaveChanges();
        }

        public Product GetDataItem(int id)
        {
            return data.Products.Find(id);
        }

        public IEnumerable<Product> GetDataList()
        {
            return data.Products.ToList();
        }

       

        public void Update(Product item)
        {
            data.Entry(item).State = EntityState.Modified;
        }
    }
}
