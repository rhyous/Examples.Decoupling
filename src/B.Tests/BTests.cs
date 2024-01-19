using LibraryB;
using LibraryC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace LibraryB.Tests
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
            return new B(new C());
        }

        #region DoSomething
        [TestMethod]
        public void B_DoSomething_UnableToTest_Test()
        {
            // Arrange
            var b = CreateB();

            // Act
            b.DoSomething();

            // Assert
            // What do we assert?
            _mockRepository.VerifyAll();
        }
        #endregion
    }
}
