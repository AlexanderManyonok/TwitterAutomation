using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using TwitterAutomation.PageObjects;
using SeleniumExtras.PageObjects;
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace TwitterAutomation.TestCases
{
    class FollowingTest : BaseTest
    {
        [Test]
        public void Test()
        {
            var loginPage = new LoginPage();
            var profilePage = new ProfilePage();
            var followingPage = new FollowingPage();
            PageFactory.InitElements(driver, loginPage);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            loginPage.PerformLogin();
            driver.Navigate().GoToUrl("https://twitter.com/NotPetrarka");
            PageFactory.InitElements(driver, profilePage);
            string a = profilePage.ReadersCount.Text;
            driver.Navigate().GoToUrl("https://twitter.com/NotPetrarka/following");
            PageFactory.InitElements(driver, followingPage);
            if (followingPage.Readers.Count.ToString()!=a)
            {
                throw new Exception();
            }
            Assert.Pass();
        }
    }
}
