using LibraryB;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace LibraryB.Implementation2.Tests
{
    [TestClass]
    public class BTests
    {
        private MockRepository _mockRepository;

        [TestInitialize]
        public void TestInitialize()
        {
            _mockRepository = new MockRepository(MockBehavior.Strict);
        }

        private B CreateB()
        {
            return new B();
        }

        #region DoSomething
        [TestMethod]
        public void B_DoSomething_UnableToTest_Test()
        {
            // Arrange
            var a = CreateB();

            // Act
            a.ReturnSomething();

            // Assert
            // What do we assert?
            _mockRepository.VerifyAll();
        }
        #endregion
    }
}
