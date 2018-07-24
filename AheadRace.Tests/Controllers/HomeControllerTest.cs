using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AheadRace;
using AheadRace.Controllers;

namespace AheadRace.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {

        /// <summary>
        /// Test the LeapYear dates diffrence in days.
        /// </summary>
        [TestMethod]
        public void IndexPostLeapYear()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index(new Models.Date() { StartDate = "01/02/2016", EndDate = "01/03/2016" }) as ViewResult;

            // Assert
            Assert.AreEqual(Convert.ToInt64(29), result.ViewData["Message"]);
        }

        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

       

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
