using hospital;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Testhospital
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]
        public void CalculateYearsOfService()
        {
            employee e = new employee ("Nafisa", "abcd", "1234", "nafisa@yahoo.com", new DateTime(2010, 1, 1));
            Assert.AreEqual(13, e.CalculateYearsOfService());
        }
            
    }
}