using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using TwitterAutomation.PageObjects;


namespace TwitterAutomation.TestCases
{
    class HomePageTest : BaseTest
    {
        [Test]
        public void Test1()
        {
            var homePage = new HomePage();
            var loginPage = new LoginPage();
            PageFactory.InitElements(driver, loginPage);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            loginPage.PerformLogin();
            PageFactory.InitElements(driver, homePage);
            Random r = new Random();
            int a = r.Next(0, 10000);
            homePage.TweetField.Click();
            homePage.TweetField.SendKeys("Beep-boop"+ a.ToString());
            homePage.EmojiMenu.Click();
            homePage.RobotEmoji.Click();
            driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div/div/div[2]/div[3]/div/div/div/div[1]/div/div[1]/div/div/div/div[2]/input")).SendKeys(Keys.Escape);
            driver.FindElement(By.XPath("/html/body/div/div/div/div/main/div/div/div/div[1]/div/div[2]/div[2]/div[1]/div/div/div[2]/div[2]/div/div/div[2]/div[3]")).Click();
            Assert.Pass();
        }


    }
}
