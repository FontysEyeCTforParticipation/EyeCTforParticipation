﻿using System;
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
            int id = Tables.HelpRequest.Count() > 0 ? Tables.User.Max(x => x.Id) + 1 : 1;
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
        public void ApproveRegistration(int userId)
        {
            var results = from user in Tables.User
                          where user.Id == userId
                          select user;
            if (results.Count() == 1)
            {
                UserModel result = results.ElementAt(0);
                result.Approved = true;
            }
        }
        public void Edit(UserModel updatedUser)
        {
            var results = from user in Tables.User
                          where user.Id == updatedUser.Id
                          select user;
            if (results.Count() == 1)
            {
                //(Email, Name, Password, Birthdate, Approved)
                UserModel result = results.ElementAt(0);
                result.Email = updatedUser.Email;
                result.Name = updatedUser.Name;
                result.Password = updatedUser.Password;
                result.Birthdate = updatedUser.Birthdate;
                result.Approved = updatedUser.Approved;
            }
        }
        public void Delete(int deletedUserId)
        {
            throw new NotImplementedException();
        }
        public void AddHelpSeeker(int helpSeekerId, int aidWorkerId)
        {
            Tables.HelpSeekerAidWorker.Add(new HelpSeekerAidWorkerModel
            {
                HelpSeekerUserId = helpSeekerId,
                AidWorkerUserId = aidWorkerId,
                Approved = false
            });
        }
        public void RemoveHelpSeeker(int helpSeekerId, int aidWorkerId)
        {
            throw new NotImplementedException();
        }
        public void ChangeApproveAidWorker(int helpSeekerId, int aidWorkerId, bool approved)
        {
            throw new NotImplementedException();
        }
        public List<UserModel> GetHelpSeekers(int aidWorkerId)
        {
            throw new NotImplementedException();
        }
        public List<UserModel> GetAidWorkers(int HelpSeekerId)
        {
            throw new NotImplementedException();
        }

    }
}
