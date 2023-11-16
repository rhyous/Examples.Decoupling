using LibraryA;
using LibraryB.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace LibraryA.Tests
{
    [TestClass]
    public class ATests
    {
        private MockRepository _mockRepository;
        private Mock<IB> _mockB;

        [TestInitialize]
        public void TestInitialize()
        {
            _mockRepository = new MockRepository(MockBehavior.Strict);
            _mockB = _mockRepository.Create<IB>();
        }

        private A CreateA()
        {
            return new A(_mockB.Object);
        }

        #region DoSomething
        [TestMethod]
        public void A_DoSomething_UnableToTest_Test()
        {
            // Arrange
            var a = CreateA();
            // Setup the mock
            _mockB.Setup(m => m.DoSomething());

            // Act
            a.DoSomething();

            // Assert
            // The below will now at least assert that B.DoSomething was called.
            _mockRepository.VerifyAll();
        }
        #endregion
    }
}
