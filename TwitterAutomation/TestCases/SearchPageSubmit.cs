using NUnit.Framework;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;
using TwitterAutomation.PageObjects;

namespace TwitterAutomation.TestCases
{
    class SearchPageSubmit : BaseTest
    {
        [Test]
        public void Test()
        {
            var loginPage = new LoginPage();
            var searchPage = new SearchPage();
            PageFactory.InitElements(driver, loginPage);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            loginPage.PerformLogin();
            driver.Navigate().GoToUrl("https://twitter.com/explore");
            PageFactory.InitElements(driver, searchPage);
            searchPage.SearchField.SendKeys("Elon musk");
            searchPage.SearchField.Submit();
            Thread.Sleep(5000);
            Assert.Pass();
            
        }
    }
}
