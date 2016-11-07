using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCTforParticipation.Models;
using EyeCTforParticipation.Data.MemoryContext;

namespace EyeCTforParticipation.Data
{
    class UserMemoryContext : IUserContext
    {
        public UserModel Login(string rfid)
        {
            var result = from user in Tables.User
                         where user.Rfid == rfid
                         select new UserModel
                         {
                             Id = user.Id,
                             Role = user.Role,
                             Name = user.Name,
                             Approved = user.Approved
                         };
            return result.Count() > 0 ? result.First() : null;
        }

        public UserModel LoginPassword(string email)
        {
            var result = from user in Tables.User
                         where user.Email == email
                         select new UserModel
                         {
                             Id = user.Id,
                             Role = user.Role,
                             Name = user.Name,
                             Password = user.Password,
                             Approved = user.Approved
                         };
            return result.Count() > 0 ? result.First() : null;
        }

        public int Register(UserModel user, bool approved)
        {
            int id = Tables.User.Count() > 0 ? Tables.User.Max(x => x.Id) + 1 : 1;
            Tables.User.Add(new UserModel
            {
                Id = id,
                Role = user.Role,
                Email = user.Email,
                Name = user.Name,
                Password = user.Password,
                Birthdate = user.Birthdate,
                Approved = approved
            });
            return id;
        }
        public void approveRegistration(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
