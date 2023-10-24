namespace EfiBankApiIntegrationTest.Security
{
    public class EfiBankAuthorizationTest : EfiBankTest
    {
        [Fact]
        public void AuthorizeTest()
        {
            Assert.NotNull(_accessToken);
        }
    }
}
