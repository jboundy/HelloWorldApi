using System.Web.Mvc;
using HelloWorld.Api.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace HelloWorld.Api.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void GetRequestReturnsHelloWorld()
        {
            var mockHelloWorldController = new HelloWorldController();

            var value = mockHelloWorldController.Get();

            Assert.AreEqual("Hello World!", value);
        }
    }
}
