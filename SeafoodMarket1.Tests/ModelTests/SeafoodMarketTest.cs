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
            newsletter.Email = "lena@gmail.com";

            //Act
            var result = newsletter.Email;

            //Assert
            Assert.Equal("lena@gmail.com", result);
        }
    }
}