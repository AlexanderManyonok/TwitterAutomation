using OpenQA.Selenium;

namespace TwitterAutomation.PageObjects
{
    public class ProfilePage
    {
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "/html/body/div/div/div/div/main/div/div/div/div[1]/div/div[2]/div/div/div[1]/div/div[4]/div[1]/a/span[1]")]
        public IWebElement ReadersCount;
    }
}
