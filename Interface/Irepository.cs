using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Interface
{
    interface Irepository<T> where T : class
    {
        /// <summary>
        /// получение всех объектов
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetDataList();
        /// <summary>
        ///  получение одного объекта по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetDataItem(int id);
        /// <summary>
        /// создание объекта
        /// </summary>
        /// <param name="item"></param>
        void Create(T item);
        /// <summary>
        /// обновление объекта
        /// </summary>
        /// <param name="item"></param>
        void Update(T item);
        /// <summary>S
        /// удаление объекта по id
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);
        
      
    }
}
