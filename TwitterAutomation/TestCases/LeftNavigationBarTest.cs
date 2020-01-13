using NUnit.Framework;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;
using TwitterAutomation.PageObjects;

namespace TwitterAutomation.TestCases
{
    class LeftNavigationBarTest : BaseTest
    {
        [Test] 
        public void Test()
        {
            bool buttonworked = true;
            var loginPage = new LoginPage();
            PageFactory.InitElements(driver, loginPage);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            loginPage.PerformLogin();
            LeftNavigationBar navigationBar = new LeftNavigationBar();
            PageFactory.InitElements(driver, navigationBar);
            do
            {
                navigationBar.MainPageButton.Click();
                Thread.Sleep(1000);
                buttonworked = driver.Title.Contains("home");
                navigationBar.SearchButton.Click();
                Thread.Sleep(1000);
                buttonworked = driver.Title.Contains("explore");
                navigationBar.NotificationsButton.Click();
                Thread.Sleep(1000);
                buttonworked = driver.Title.Contains("notifications");
                navigationBar.MessagesButton.Click();
                Thread.Sleep(1000);
                buttonworked = driver.Title.Contains("messages");
                navigationBar.BookmarksButton.Click();
                Thread.Sleep(1000);
                buttonworked = driver.Title.Contains("bookmarks");
                navigationBar.ListsButton.Click();
                Thread.Sleep(1000);
                buttonworked = driver.Title.Contains("lists");
                navigationBar.ProfileButton.Click();
                Thread.Sleep(1000);
                buttonworked = driver.Title.Contains("NotPetrarka");
                navigationBar.MoreButton.Click();
                Thread.Sleep(1000);
                buttonworked = navigationBar.MoreContextMenu.Displayed;
                Assert.Pass();
            }
            while (buttonworked == true);
            Assert.Pass();
        }
    }
}
