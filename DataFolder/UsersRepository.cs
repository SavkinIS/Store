using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Store.AuUser;
using Store.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.DataFolder
{
    public class UsersRepository : Irepository<User>
    {
        StoreContext data;

        public UsersRepository(StoreContext data)
        {
            this.data = data;
        }

        public void Create(User item)
        {
            data.Users.Add(item);
        }
        
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User GetDataItem(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetDataList()
        {
            throw new NotImplementedException();
        }

        public void Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}
