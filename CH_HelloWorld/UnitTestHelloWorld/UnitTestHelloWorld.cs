using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestHelloWorld.WSAPIService;


namespace UnitTestHelloWorld
{
    [TestClass]
    public class UnitTestHelloWorld
    {
        [TestMethod]
        public void TestHelloWorld()
        {
            WSHelloWorld service = new WSHelloWorld();
            //Arrange
            string expected = "Hello World";
            //Act
            string actual = service.GetHello();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
