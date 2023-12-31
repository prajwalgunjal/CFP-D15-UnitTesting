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


        [TestMethod]
        [DataRow("prajwal23@gmail.com",true)]
        [DataRow("prajwal23@.com",false)]
        public void CHeckEmail_ShouldReturnTrue_IfValid(string email , bool expected) { 
            bool result = method.Email(email);
            Assert.AreEqual(expected,result);
        }

        [TestMethod]
        [DataRow("+91 9881640062",true)]
        [DataRow("9881640062",false)]

        public void CHeckPhoneNumber_ShouldReturnTrue_IfValid(string number, bool expected)
        {
            bool result = method.Phone(number);   
            Assert.AreEqual(expected,result);
        }
        
        
        [TestMethod]
        [DataRow("Prajwalll",true)]
        [DataRow("123",false)]

        public void CHeckPassword_ShouldReturnTrue_IfValid(string password, bool expected)
        {
            bool result = method.Password(password);   
            Assert.AreEqual(expected,result);
        }



    }
}