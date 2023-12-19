﻿using LibraryA.Interfaces;
using Moq;

namespace LibraryA.Tests
{
    [TestClass]
    public class ATests
    {
        private MockRepository _mockRepository;
        private Mock<ISomethingProvider> _mockDoSomethingEvent;

        [TestInitialize]
        public void TestInitialize()
        {
            _mockRepository = new MockRepository(MockBehavior.Strict);
            _mockDoSomethingEvent = _mockRepository.Create<ISomethingProvider>();
        }

        private A CreateA()
        {
            return new A(_mockDoSomethingEvent.Object);
        }

        #region DoSomething
        [TestMethod]
        public void A_DoSomething_UnableToTest_Test()
        {
            // Arrange
            var a = CreateA();
            // Setup the mock
            _mockDoSomethingEvent.Setup(m => m.ReturnSomething());

            // Act
            a.ReturnSomething();

            // Assert
            // The below will now at least assert that B.DoSomething was called.
            _mockRepository.VerifyAll();
        }
        #endregion
    }
}
