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
    /// Репозитрий Элементов Заказа
    /// </summary>
    public class OrderItemsRepository : Irepository<OrderItem>
    {

        StoreContext data;

        public OrderItemsRepository(StoreContext data)
        {
            this.data = data;
        }

        public void Create(OrderItem item)
        {
            data.OrderItems.Add(item);
        }

        public void Delete(int id)
        {
            var orderItem = data.OrderItems.Find(id);
            data.OrderItems.Remove(orderItem);
        }

        public OrderItem GetDataItem(int id)
        {
            return data.OrderItems.Find(id);
        }

        public IEnumerable<OrderItem> GetDataList()
        {
            return data.OrderItems.ToList();
        }

        

        public void Update(OrderItem item)
        {
            data.Entry(item).State = EntityState.Modified;
        }
    }
}
