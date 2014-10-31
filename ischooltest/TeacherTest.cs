using System;
using iSchool;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ischooltest
{
    [TestClass]
    public class TeacherTest
    {

        private Teacher _teacher;

        [TestInitialize]
        public void BeforeTest()
        {
            _teacher = new Teacher("s", 50000);
        }

        [TestMethod]
        public void TestName()
        {
           
            Assert.AreEqual("m",_teacher.Name);
            try
            {
                _teacher.Name =null;
                Assert.Fail();
            }
            catch (ArgumentException asd)
            {
                Assert.AreEqual("Value is Nullllllloooooooshittttt or less than 2", asd.Message);
                
            }
        }

       


    }
}


