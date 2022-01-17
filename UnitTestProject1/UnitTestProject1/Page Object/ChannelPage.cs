using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.Page_Object
{
    public class ChannelPage
    {
        IWebDriver driver;
        public ChannelPage(IWebDriver driver1)
        {
            this.driver = driver1;
            PageFactory.InitElements(driver, this);

        }

        [FindsBy(How=How.LinkText, Using="BB Ki Vines")]
        public IWebElement ChannelName { get; set; }   
        
        public String getChannelName()
        {
            return ChannelName.Text;
        }

    }
}
