using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTestProject1.Page_Object
{
    public class ResultPage
    {
        IWebDriver driver;
        public ResultPage(IWebDriver driver1)
        {
            this.driver = driver1;
            PageFactory.InitElements(driver, this);

        }

        [FindsBy(How=How.LinkText,Using = "BB Ki Vines")]
        public IWebElement ChannelNameLinkText { get; set; }

        public ChannelPage NavigateToChannel()
        {
            Thread.Sleep(3000);
            ChannelNameLinkText.Click();
            return new ChannelPage(driver);
        }
    }
}
