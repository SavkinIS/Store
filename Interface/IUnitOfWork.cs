using Store.DataFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Interface
{
    public interface IUnitOfWork
    {
        /// <summary>
        /// Получить список продуктов
        /// </summary>
        /// <returns></returns>
        public ProductsRepository Products { get; }

        /// <summary>
        /// получить все заказы
        /// </summary>
        /// <returns></returns>
        public OrderRepository Orders { get; }

        /// <summary>
        /// Получить список Элементов заказов
        /// </summary>
        /// <returns></returns>
        public OrderItemsRepository OdererItems { get; }

        /// <summary>
        /// Получить всех заказчиков
        /// </summary>
        /// <returns></returns>
        public CustomerRepository Customers { get; }

        /// <summary>
        /// Получить Всех пользователей
        /// </summary>
        /// <returns></returns>
        public UsersRepository Users { get; }

        /// <summary>
        /// сохранение изменений
        /// </summary>
        public void Save();
        
    }
}
