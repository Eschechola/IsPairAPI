using IsPairAPI.Services;
using Xunit;

namespace IsPairApi.Tests
{
    public class PairServiceTests
    {
        private readonly IPairService _sut;

        public PairServiceTests()
        {
            _sut = new PairService();
        }

        [Fact]
        public void IsPair_WhenNumberIsPair_ReturnsTrue()
        {
            // Arrange
            var number = 4;

            // Act
            var result = _sut.IsPair(number);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPair_WhenNumberIsNotPair_ReturnsFalse()
        {
            // Arrange
            var number = 3;

            // Act
            var result = _sut.IsPair(number);

            // Assert
            Assert.False(result);
        }
    }
}
