using System.Globalization;
using UserRegg;

namespace UserRegTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Prajwal",true)]
        [DataRow("prajkta",false)]
        public void TestMethod1(string name , bool expected)
        {
            UserRegMethod method = new UserRegMethod();
            bool result =method.FirstName(name);
            Assert.AreEqual(expected,result);
        }
    }
}