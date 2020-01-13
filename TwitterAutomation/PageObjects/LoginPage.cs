using OpenQA.Selenium;


namespace TwitterAutomation.PageObjects
{
    public class LoginPage
    {
     /*   private IWebDriver driver;*/

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "/html/body/div[1]/div/div[1]/div[1]/div[1]/form/div[1]/input")]
        public IWebElement EmailField;

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "/html/body/div[1]/div/div[1]/div[1]/div[1]/form/div[2]/input")]
        public IWebElement PasswordField;

       /* public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
*/
        public void PerformLogin()
        {
            EmailField.Click();
            EmailField.SendKeys("San4e3.by@gmail.com");
            PasswordField.Click();
            PasswordField.SendKeys("1233357");
            PasswordField.Submit();
        }
    }
}
