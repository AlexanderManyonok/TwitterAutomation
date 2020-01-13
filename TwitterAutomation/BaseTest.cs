using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace TwitterAutomation
{
    public class BaseTest
    {
       

       protected IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void setUp() 
        {
            driver.Manage().Window.Maximize();
            driver.Url = "https://twitter.com";

        }
      /*  [TearDown]

        public void td()
        {
            driver.Close();
            driver.Quit();
        }*/
    }
}
