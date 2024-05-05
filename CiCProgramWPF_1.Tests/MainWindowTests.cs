using ClassLibrary1;

namespace CiCProgramWPF_1.Tests
{
    public class MainWindowTests
    {
        [Fact]
        public void GetGraphicRepresentation_ReturnsCorrectRepresentation_ForDigit0()
        {
            // Arrange
            ZadahaOne zadahaOne = new ZadahaOne();
            int digit = 0;
            string[] expected = new string[] { "##", "##", "##", "##" };

            // Act
            string[] actual = zadahaOne.GetGraphicRepresentation(digit);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetGraphicRepresentation_ReturnsCorrectRepresentation_ForDigit1()
        {
            // Arrange
            ZadahaOne zadahaOne = new ZadahaOne();
            int digit = 1;
            string[] expected = new string[] { ".#", "##", ".#", ".#" };

            // Act
            string[] actual = zadahaOne.GetGraphicRepresentation(digit);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetGraphicRepresentation_ReturnsCorrectRepresentation_ForDigit2()
        {
            // Arrange
            ZadahaOne zadahaOne = new ZadahaOne();
            int digit = 2;
            string[] expected = new string[] { "##", ".#", "##", "##" };

            // Act
            string[] actual = zadahaOne.GetGraphicRepresentation(digit);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetGraphicRepresentation_ReturnsCorrectRepresentation_ForDigit4()
        {
            // Arrange
            ZadahaOne zadahaOne = new ZadahaOne();
            int digit = 4;
            string[] expected = new string[] { "##", "##", ".#", ".#" };

            // Act
            string[] actual = zadahaOne.GetGraphicRepresentation(digit);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}