using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace SpecflowSeleniumPOM.Tests_Standard_Nunit_
{
    class StandardNunitTest
    {
        IWebDriver driver;
        [Category("TFSFriendly")]
        [SetUp]
        public void Init()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void TestNunitExample()
        {
            driver.Url = "https://www.amazon.co.uk";

            string title = driver.Title;

            Assert.That(title.Equals("goose"));

        }
        
        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }
        
    }
}
