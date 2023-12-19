using LibraryA.Interfaces;
using LibraryA.Models;
using Moq;

namespace LibraryA.Tests
{
    [TestClass]
    public class ATests
    {
        private MockRepository _mockRepository;
        private Mock<ISomethingProvider> _mockSomethingProvider;

        [TestInitialize]
        public void TestInitialize()
        {
            _mockRepository = new MockRepository(MockBehavior.Strict);
            _mockSomethingProvider = _mockRepository.Create<ISomethingProvider>();
        }

        private A CreateA()
        {
            return new A(_mockSomethingProvider.Object);
        }

        #region DoSomething
        [TestMethod]
        public void A_DoSomething_UnableToTest_Test()
        {
            // Arrange
            var a = CreateA();
            // Setup the mock
            var something = new Something();
            _mockSomethingProvider.Setup(m => m.ReturnSomething())
                                  .Returns(something);
            // Act
            var actual = a.ReturnSomething();

            // Assert
            // The below will now at least assert that B.DoSomething was called.
            _mockRepository.VerifyAll();
        }
        #endregion
    }
}
