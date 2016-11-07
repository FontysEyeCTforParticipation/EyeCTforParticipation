using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EyeCTforParticipation.Logic;
using EyeCTforParticipation.Data;

namespace UnitTestEyeCTforParticipation
{
    [TestClass]
    public class TestUserRepository
    {
        UserRepository userRepository;
        UserMemoryContext userMemoryContext;
        public TestUserRepository()
        {
            userMemoryContext = new UserMemoryContext();
            userRepository = new UserRepository(userMemoryContext);
        }

        [TestMethod]
        public void TestCreate()
        {
            Assert.AreEqual(userRepository.context, userMemoryContext, "memoryContext incorrect");
            
        }
    }
}
