using EfiBankApiIntegration.Extensions;

namespace EfiBankApiIntegrationTest.Extensions
{
    public class ConvertExtensionTest
    {
        [Fact]
        public void ToBase64EncodeTest()
        {
            // Arrange
            string input = "Hello, World!";
            string expected = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(input));

            // Act
            string result = input.ToBase64Encode();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
