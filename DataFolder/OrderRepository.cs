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
    /// Репозитрий заказов
    /// </summary>
    public class OrderRepository : Irepository<Order>
    {
       StoreContext data;

        public OrderRepository(StoreContext data)
        {
            this.data = data;
        }

        public void Create(Order item)
        {
            data.Orders.Add(item);
            data.SaveChanges();
        }

        public void Delete(int id)
        {
            var order = data.Orders.Find(id);
            data.Orders.Remove(order);
            data.SaveChanges();
        }

        public Order GetDataItem(int id)
        {
            return data.Orders.Find(id);
        }

        public IEnumerable<Order> GetDataList()
        {
            return data.Orders.ToList();
        }

     

        public void Update(Order item)
        {
            data.Entry(item).State = EntityState.Modified;
        }
    }
}
