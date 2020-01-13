using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;
using TwitterAutomation.PageObjects;

namespace TwitterAutomation.TestCases
{
    class SearchPageRecommended : BaseTest
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
            searchPage.SearchField.SendKeys("A");
            Thread.Sleep(3000);
            IWebElement recommendation = driver.FindElement(By.XPath("/html/body/div/div/div/div/main/div/div/div/div[1]/div/div[1]/div[1]/div/div/div/div/div[1]/div[2]/div/div/div/form/div[2]/div/div[3]/div[3]/div"));
            recommendation.Click();
            Assert.Pass();

        }
    }
}
