using OpenQA.Selenium;

namespace TwitterAutomation.PageObjects
{
    public class HomePage
    {

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "/html/body/div/div/div/div/main/div/div/div/div[1]/div/div[2]/div[2]/div[1]/div/div/div[2]/div[1]/div/div/div/div/div/div/div/div[1]/div[1]/div/div/div/div[2]/div")]
        public IWebElement TweetField;

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "/html/body/div/div/div/div/main/div/div/div/div[1]/div/div[2]/div[2]/div[1]/div/div/div[2]/div[2]/div/div/div[1]/div[4]")]
        public IWebElement EmojiMenu;

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "/html/body/div/div/div/div[1]/div/div/div[2]/div[3]/div/div/div/div[1]/div/div[3]/div/div[3]/div/div[2]/div/div[12]/div[3]/div/div")]
        public IWebElement RobotEmoji;

    }
}
