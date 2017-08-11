using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using SeafoodMarket.Controllers;
using SeafoodMarket.Models;
using Microsoft.AspNetCore.Mvc;

namespace SeafoodMarket1.Tests.ControllerTests
{
    public class NewsletterControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            NewsletterController controller = new NewsletterController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ModelList_Index_Test()
        {
            //Arrange
            NewsletterController controller = new NewsletterController();
            IActionResult actionResult = controller.Index();
            ViewResult indexView = controller.Index() as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsType<List<Newsletter>>(result);
        }
    }
}
