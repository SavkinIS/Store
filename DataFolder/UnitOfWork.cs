using Store.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.DataFolder
{
    public class UnitOfWork : IUnitOfWork
    {
        StoreContext data = new StoreContext();
        ProductsRepository products;
        OrderRepository orders;
        OrderItemsRepository orderItems;
        CustomerRepository customers;
        UsersRepository users;

        public ProductsRepository Products
        {
            get
            {
                if (products == null)
                {
                    products = new ProductsRepository(data);
                }
                return products;
            }
        }
        public OrderRepository Orders
        {
            get
            {
                if (orders == null) { orders = new OrderRepository(data); }
                return orders;
            }
        }
        public OrderItemsRepository OdererItems
        {
            get
            {
                if (orderItems == null) { orderItems = new OrderItemsRepository(data); }
                return orderItems;
            }
        }
        public CustomerRepository Customers
        {
            get
            {
                if(customers == null) { customers = new CustomerRepository(data); }
                return customers;
            }
        }


        public UsersRepository Users
        {
            get
            {
                if (users == null) { users = new UsersRepository(data); }
                return users;
            }
        }




        /// <summary>
        /// сохранение изменений
        /// </summary>
        public void Save()
        {
            data.SaveChanges();
        }
    }
}
