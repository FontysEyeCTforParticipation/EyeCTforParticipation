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
        UserModel userModel2;
        public TestUserRepository()
        {
            userMemoryContext = new UserMemoryContext();
            userRepository = new UserRepository(userMemoryContext);
            userModel = new UserModel {
                Id = 1,
                Role = UserRole.Admin,
                Name = @"INSERT_SUBJECT_NAME_HERE",
                Email = "a@b",
                Rfid = "RfidCode",
                Password = "Password",
                Birthdate = new DateTime(1995, 07, 10),
                Approved = false
                };
            userModel2 = new UserModel
            {
                Id = 2,
                Role = UserRole.AidWorker,
                Name = @"2",
                Email = "2@b",
                Rfid = "RfidCode2",
                Password = "Password",
                Birthdate = new DateTime(1995, 02, 10),
                Approved = true
            };
            userMemoryContext.Register(userModel, true);
            userMemoryContext.Register(userModel2, false);
        }

        [TestMethod]
        public void TestCreate()
        {
            Assert.AreEqual(userRepository.context, userMemoryContext, "memoryContext incorrect");
            
        }
        [TestMethod]
        public void TestLogin()
        {
            Assert.AreEqual(userModel, userRepository.Login("RfidCode"));
            Assert.AreEqual(null, userRepository.Login("aap"));
            Assert.AreEqual(null, userRepository.Login("RfidCode2"));

            Assert.AreEqual(userModel, userRepository.Login(@"INSERT_SUBJECT_NAME_HERE", "Password"));
            Assert.AreEqual(null, userRepository.Login(@"INSERT_SUBJECT_NAME_HERE", "wrong"));
            Assert.AreEqual(null, userRepository.Login(@"2", "Password"));
        }
    }
}
