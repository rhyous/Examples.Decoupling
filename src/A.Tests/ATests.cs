﻿using LibraryA.Interfaces;
using Moq;

namespace LibraryA.Tests
{
    [TestClass]
    public class ATests
    {
        private MockRepository _mockRepository;
        private Mock<ISerializer> _mockSerializer;

        [TestInitialize]
        public void TestInitialize()
        {
            _mockRepository = new MockRepository(MockBehavior.Strict);
            _mockSerializer = _mockRepository.Create<ISerializer>();
        }

        private A CreateA()
        {
            return new A(_mockSerializer.Object);
        }

        #region Serialize
        [TestMethod]
        public void A_Serialize_SerializesObject_Test()
        {
            // Arrange
            var a = CreateA();
            // Setup the mock
            var serializedString = "{ \"Name\": \"Some Name\"}";
            _mockSerializer.Setup(m => m.Serialize(a)).Returns(serializedString);

            // Act
            var actual = a.Serialize();

            // Assert
            Assert.AreEqual(serializedString, actual);
            // The below will now at least assert that B.DoSomething was called.
            _mockRepository.VerifyAll();
        }
        #endregion
    }
}
