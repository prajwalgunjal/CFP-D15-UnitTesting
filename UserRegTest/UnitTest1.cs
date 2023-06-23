using System.Globalization;
using UserRegg;

namespace UserRegTest
{
    [TestClass]
    public class UnitTest1
    {   
        private UserRegMethod method;

        [TestInitialize]

        public void Setup()
        {
            method = new UserRegMethod();
        }

        [TestMethod]
        [DataRow("Prajwal",true)]
        [DataRow("prajkta",false)]
        public void CheckFirstName_SHouldReturn_True_IfValid(string name , bool expected)
        { 
            bool result =method.FirstName(name);
            Assert.AreEqual(expected,result);
        }

        [TestMethod]
        [DataRow("Gunjal", true)]
        [DataRow("bhosale", false)]
        public void CheckLastName_ShouldReturn_True_IfValid(string name , bool excpeted)
        {
            bool result = method.LastName(name);
            Assert.AreEqual(excpeted,result);
        }



    }
}