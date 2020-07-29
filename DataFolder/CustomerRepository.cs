using Store.Interface;
using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Store.DataFolder
{
    /// <summary>
    /// Репозитрий заказчиков
    /// </summary>
    public class CustomerRepository : Irepository<Customer>
    {
        StoreContext data;

        public CustomerRepository(StoreContext data )
        {
            this.data = data;
        }

        public void Create(Customer item)
        {
            data.Customers.Add(item);
        }

        public void Delete(int id)
        {
            var customer = data.Customers.Find(id);
            data.Customers.Remove(customer);
        }

        public Customer GetDataItem(int id)
        {
            return data.Customers.Find(id);
        }

        public IEnumerable<Customer> GetDataList()
        {
            return data.Customers.ToList();
        }


        public void Update(Customer item)
        {
            data.Entry(item).State = EntityState.Modified;
        }
    }
}
