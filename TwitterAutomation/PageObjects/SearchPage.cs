using OpenQA.Selenium;

namespace TwitterAutomation.PageObjects
{
    public class SearchPage
    {
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "/html/body/div/div/div/div/main/div/div/div/div[1]/div/div[1]/div[1]/div/div/div/div/div[1]/div[2]/div/div/div/form/div[1]/div/div/div[2]/input")]
        public IWebElement SearchField;
    }
}
