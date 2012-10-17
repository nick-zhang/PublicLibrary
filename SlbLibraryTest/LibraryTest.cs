using Microsoft.VisualStudio.TestTools.UnitTesting;
using SlbLibrary;

namespace SlbLibraryTest
{
    [TestClass]
    public class LibraryTest
    {
        [TestMethod]
        public void ShouldGetWelcomeMessageWhenOpenTheApplication()
        {
            var slbLibrary = new Library();
            var message = slbLibrary.Start();
            Assert.AreEqual(Library.WELCOME_MESSAGE, message);
        }
    }
}
