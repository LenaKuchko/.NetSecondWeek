using SeafoodMarket.Models;
using Xunit;

namespace SeafoodMarket.Tests
{
    public class NewsletterTest
    {
        [Fact]
        public void GetEmailTest()
        {
            //Arrange
            var newsletter = new Newsletter();

            //Act
            var result = item.Email;

            //Assert
            Assert.Equal("lena@gmail.com", result);
        }
    }
}