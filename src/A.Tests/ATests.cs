using LibraryA;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace LibraryA.Tests
{
    [TestClass]
    public class ATests
    {
        private MockRepository _mockRepository;

        [TestInitialize]
        public void TestInitialize()
        {
            _mockRepository = new MockRepository(MockBehavior.Strict);
        }

        private A CreateA()
        {
            return new A();
        }

        #region DoSomething
        [TestMethod]
        public void A_DoSomething_UnableToTest_Test()
        {
            // Arrange
            var a = CreateA();

            // Act
            a.DoSomething();

            // Assert
            // What do we assert? 
            // We can't assert that B was called as is.
            _mockRepository.VerifyAll();
        }
        #endregion
    }
}
