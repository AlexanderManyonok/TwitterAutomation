using NUnit.Framework;
using TwitterAutomation.PageObjects;
using SeleniumExtras.PageObjects;
using System;

namespace TwitterAutomation.TestCases
{
    public class LogInTest : BaseTest
    {

        [Test]
        public void Test()
        {
            var loginPage = new LoginPage();
            PageFactory.InitElements(driver, loginPage);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Assert.Pass();
        }
    }
}