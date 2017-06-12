using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;

namespace SpecflowSeleniumPOM.Pages
{
    public class HomePage
    {
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "twotabsearchtextbox")]
        public IWebElement searchBox;

        [FindsBy(How = How.ClassName, Using = "nav-input")]
        public IWebElement searchButton;

        [FindsBy(How = How.LinkText, Using = "adidas Men's Chelsea Fc 2016 Home Jersey")]
        public IWebElement chelseaShirt;

        [FindsBy(How = How.Id, Using = "productTitle")]
        public IWebElement productTitle;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);     
        }
        public void searchProduct()
        {
            searchBox.SendKeys("Chelsea shirt");

            searchButton.Click();
        }

        public void selectProduct()
        {
            chelseaShirt.Click();
        }

        public void checkProduct()
        {
            string title = productTitle.Text;

            Assert.That(title.Contains("adidas Men's Chelsea Fc 2016 Home Jersey"));
        }

    }
}
