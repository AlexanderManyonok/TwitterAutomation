using OpenQA.Selenium;

namespace TwitterAutomation.PageObjects
{
    public class LeftNavigationBar
    {
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "/html/body/div/div/div/div/header/div/div/div/div/div[2]/nav/a[1]/div")]
        public IWebElement MainPageButton;

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "/html/body/div/div/div/div/header/div/div/div/div/div[2]/nav/a[2]")]
        public IWebElement SearchButton;

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "/html/body/div/div/div/div/header/div/div/div/div/div[2]/nav/a[3]")]
        public IWebElement NotificationsButton;

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "/html/body/div/div/div/div/header/div/div/div/div/div[2]/nav/a[4]")]
        public IWebElement MessagesButton;

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "/html/body/div/div/div/div/header/div/div/div/div/div[2]/nav/a[5]")]
        public IWebElement BookmarksButton;

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "/html/body/div/div/div/div/header/div/div/div/div/div[2]/nav/a[6]")]
        public IWebElement ListsButton;

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "/html/body/div/div/div/div/header/div/div/div/div/div[2]/nav/a[7]")]
        public IWebElement ProfileButton;

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "/html/body/div/div/div/div/header/div/div/div/div/div[2]/nav/div")]
        public IWebElement MoreButton;

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "/html/body/div/div/div/div[1]/div/div/div[2]/div[3]")]
        public IWebElement MoreContextMenu;
    }
}
