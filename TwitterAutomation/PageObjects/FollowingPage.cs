using OpenQA.Selenium;
using System.Collections.Generic;


namespace TwitterAutomation.PageObjects
{
    public class FollowingPage
    {

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.CssSelector, Using = "css-901oao css-bfa6kz r-hkyrab r-1qd0xha r-a023e6 r-vw2c0b r-ad9z0x r-bcqeeo r-3s2u2q r-qvutc0")]
        public IList<IWebElement> Readers;
    }
}
