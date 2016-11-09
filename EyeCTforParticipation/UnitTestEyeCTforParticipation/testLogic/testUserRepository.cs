using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EyeCTforParticipation.Logic;
using EyeCTforParticipation.Data;
using EyeCTforParticipation.Models;

namespace UnitTestEyeCTforParticipation
{
    [TestClass]
    public class TestUserRepository
    {
        UserRepository userRepository;
        UserMemoryContext userMemoryContext;
        UserModel userModel;
        RegisterModel registerModel1;
        RegisterModel registerModel2;
        UserModel userModel2;
        public TestUserRepository()
        {
            userMemoryContext = new UserMemoryContext();
            userRepository = new UserRepository(userMemoryContext);
            
            registerModel1 = new RegisterModel {
                //Id = 1,
                Role = UserRole.Admin,
                Name = @"INSERT_SUBJECT_NAME_HERE",
                Email = "a@b",
                Password = "Password",
                Birthdate = new DateTime(1995, 07, 10),
                };
            registerModel2 = new RegisterModel
            {
                Role = UserRole.AidWorker,
                Name = @"a",
                Email = "b@c",
                Password = "Password",
                Birthdate = new DateTime(1995, 07, 10),
            };
            userModel2 = new UserModel
            {
                //Id = 2,
                Role = UserRole.AidWorker,
                Name = @"2",
                Email = "2@b",
                Rfid = "RfidCode2",
                Password = "Password",
                Birthdate = new DateTime(1995, 02, 10),
                Approved = true
            };
            /*
            userRepository.Register();
            userRepository.ApproveRegistration()
            userMemoryContext.Register(userModel, );
            userMemoryContext.Register(userModel2, false);
            */
        }

        [TestMethod]
        public void TestRegister()
        {

            Assert.AreNotEqual(0, userRepository.Register(registerModel1), "first time Registering incorrect");
            Assert.AreNotEqual(0, userRepository.Register(registerModel2), "Second time Registering incorrect");
            
            
            

            
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))] 

        public void TestRegister2()
        {
            userRepository.Register(registerModel1);
            userRepository.Register(registerModel1);
        }

        public void TestCreate()
        {
            Assert.AreEqual(userRepository.context, userMemoryContext, "memoryContext incorrect");
            Assert.AreEqual(1, userModel.Id, "userModel1's Id isn't 1");
            Assert.AreEqual("RfidCode", userModel.Rfid, "usermodel1's rfid wrong");
        }
        [TestMethod]
        public void TestLogin()
        {
            /*
            Assert.AreEqual(userModel, userRepository.Login("RfidCode"),"RfidInlog incorrect");
            Assert.AreEqual(null, userRepository.Login("aap"), "Wrong RfidInlog incorrect");
            Assert.AreEqual(null, userRepository.Login("RfidCode2"), "unapproved can login with Rfid");

            Assert.AreEqual(userModel, (userRepository.Login(@"INSERT_SUBJECT_NAME_HERE", "Password")), "normal inlog incorrect");
            Assert.AreEqual(null, userRepository.Login(@"INSERT_SUBJECT_NAME_HERE", "wrong"), "wrong password can log in");
            Assert.AreEqual(null, userRepository.Login(@"2", "Password"), "unapproved can log in");
            */
        }
    }
}
