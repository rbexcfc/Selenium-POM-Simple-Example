using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowSeleniumPOM.Pages;

namespace SpecflowSeleniumPOM.Tests
{
    class SearchProjectTest
    {
        [Test]
        public void TestNunitPOM()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://www.amazon.co.uk";

            driver.Manage().Window.Maximize();

            var homepage = new HomePage(driver);

            homepage.searchProduct();

            homepage.selectProduct();

            homepage.checkProduct();

            driver.Close();
        }
    }
}
