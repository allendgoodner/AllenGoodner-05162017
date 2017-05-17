using System;
using DependencyInjection.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DependencyInjection.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Admin_Can_Instantiate_With_ConsoleLogger()
        {
            var target = new Admin(new ConsoleLogger());

            Assert.IsNotNull(target);
            Assert.IsInstanceOfType(target, typeof(Admin));
        }

        [TestMethod]
        public void Admin_Can_Instantiate_With_FileLogger()
        {
            var target = new Admin(new FileLogger("pathPart1", "pathPart2"));

            Assert.IsNotNull(target);
            Assert.IsInstanceOfType(target, typeof(Admin));
        }
    }
}
