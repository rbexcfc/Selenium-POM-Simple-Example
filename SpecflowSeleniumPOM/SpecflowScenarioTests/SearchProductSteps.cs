using System;
using TechTalk.SpecFlow;
using SpecflowSeleniumPOM.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecflowSeleniumPOM.SpecflowScenarioTests
{
    [Binding]
    public class SearchProductSteps
    {
        private HomePage _homepage;

        IWebDriver driver = new ChromeDriver();

        [Given(@"I have gone to the Amazon homepage")]
        public void GivenIHaveGoneToTheAmazonHomepage()
        {   
            _homepage = new HomePage(driver);

            driver.Url = "https://www.amazon.co.uk";

            driver.Manage().Window.Maximize();
        }
        
        [Given(@"I have search for a chelsea shirt")]
        public void GivenIHaveSearchForAChelseaShirt()
        {
            _homepage.searchProduct();
        }
        
        [When(@"I select the item")]
        public void WhenISelectTheItem()
        {
            _homepage.selectProduct();
        }
        
        [Then(@"the link should show the correct item details")]
        public void ThenTheLinkShouldShowTheCorrectItemDetails()
        {
            _homepage.checkProduct();

            driver.Quit();
        }
    }
}
