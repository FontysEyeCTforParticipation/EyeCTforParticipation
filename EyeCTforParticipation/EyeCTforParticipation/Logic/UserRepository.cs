using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCTforParticipation.Data;
using EyeCTforParticipation.Models;
using CryptSharp;

namespace EyeCTforParticipation.Logic
{
    class UserRepository
    {
        IUserContext context;

        public UserRepository(IUserContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Get a specific user for the RFID code.
        /// </summary>
        /// <param name="rfid">
        /// The RFID code.
        /// </param>
        /// <returns>
        /// An user.
        /// </returns>
        public UserModel Login(string rfid)
        {
            return context.Login(rfid);
        }

        /// <summary>
        /// Get a specific user for the email and password combination.
        /// </summary>
        /// <param name="email">
        /// The email.
        /// </param>
        /// <param name="password">
        /// The password.
        /// </param>
        /// <returns>
        /// An user.
        /// </returns>
        public UserModel Login(string email, string password)
        {
            UserModel user =  context.LoginPassword(email);
            if(user != null && Crypter.CheckPassword(password, user.Password))
            {
                return user;
            }
            return null;
        }

        /// <summary>
        /// Create a new user.
        /// </summary>
        /// <param name="register">
        /// The data about the new user.
        /// </param>
        public void Register(RegisterModel register)
        {
            if (register.Password == register.PasswordRepeat)
            {
                string hash = Crypter.Blowfish.Crypt(register.Password);
                bool approved = false;
                switch (register.Role)
                {
                    case UserRole.HelpSeeker:
                        approved = true;
                        break;
                    case UserRole.Volunteer:
                        break;
                    case UserRole.AidWorker:
                        break;
                }
                context.Register(new UserModel
                {
                    Role = register.Role,
                    Email = register.Email,
                    Name = register.Name,
                    Password = hash,
                    Birthdate = register.Birthdate
                }, approved);
            }
        }

        /// <summary>
        /// Approve a registration.
        /// </summary>
        /// <param name="userId">
        /// The user that registered.
        /// </param>
        public void ApproveRegistration(int userId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Send an email with a reset code.
        /// </summary>
        /// <param name="email">
        /// The email of the user that requested a reset code.
        /// </param>
        public void SendPasswordResetEmail(string email)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Change the password of the user that matches the reset code.
        /// </summary>
        /// <param name="newPassword">
        /// The new password to be set.
        /// </param>
        /// <param name="resetCode">
        /// The reset code.
        /// </param>
        public void ResetPassword(string newPassword, string resetCode)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Replace the user data with new user data.
        /// </summary>
        /// <param name="user">
        /// The new user data.
        /// </param>
        public void Edit(UserModel user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Remove an user.
        /// </summary>
        /// <param name="userId">
        /// The id of the user to be removed.
        /// </param>
        public void Delete(int userId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Add a help seeker to an aid worker.
        /// </summary>
        /// <param name="helpSeekerId">
        /// The id of the help seeker.
        /// </param>
        /// <param name="aidWorkerId">
        /// The id of the aid worker.
        /// </param>
        public void AddHelpSeeker(int helpSeekerId, int aidWorkerId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Remove a help seeker from an aid worker.
        /// </summary>
        /// <param name="helpSeekerId">
        /// The id of the help seeker.
        /// </param>
        /// <param name="aidWorkerId">
        /// The id of the aid worker.
        /// </param>
        public void RemoveHelpSeeker(int helpSeekerId, int aidWorkerId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Approve being added to an aid worker as help seeker.
        /// </summary>
        /// <param name="helpSeekerId">
        /// The id of the help seeker.
        /// </param>
        /// <param name="aidWorkerId">
        /// The id of the aid worker.
        /// </param>
        public void ApproveAidWorker(int helpSeekerId, int aidWorkerId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Disapprove a aid worker that was previously approved by a help seeker.
        /// </summary>
        /// <param name="helpSeekerId">
        /// The id of the help seeker.
        /// </param>
        /// <param name="aidWorkerId">
        /// The id of the aid worker.
        /// </param>
        /// <remarks>
        /// The aid worker needs to be previously approved before it can be disapproved.
        /// </remarks>
        public void DisapproveAidWorker(int helpSeekerId, int aidWorkerId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get a list of help seekers for an aid worker.
        /// </summary>
        /// <param name="aidWorkerId">
        /// The id of the aid worker.
        /// </param>
        /// <returns>
        /// A list of help seekers.
        /// </returns>
        /// <remarks>
        /// The help seekers need to have approved the aid worker.
        /// </remarks>
        List<UserModel> GetHelpSeekers(int aidWorkerId)
        {
            throw new NotImplementedException();
        }
    }
}
