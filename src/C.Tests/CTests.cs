using Moq;

namespace LibraryC.Tests
{
    [TestClass]
    public class CTests
    {
        private MockRepository _mockRepository;

        [TestInitialize]
        public void TestInitialize()
        {
            _mockRepository = new MockRepository(MockBehavior.Strict);
        }

        private C CreateC()
        {
            return new C();
        }

        #region DoSomething
        [TestMethod]
        public void C_DoSomething_UnableToTest_Test()
        {
            // Arrange
            var c = CreateC();

            // Act
            c.DoSomething();

            // Assert
            // What do we assert?
            _mockRepository.VerifyAll();
        }
        #endregion
    }
}
