using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnitTestProject1.Page_Object
{
    public class SearchPage
    {
         IWebDriver driver;
        public SearchPage(IWebDriver driver1)
        {
            this.driver = driver1;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Name, Using ="search_query")]
        public IWebElement SearchTextBox { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='search-icon-legacy']")]
        public IWebElement SearchButton { get; set; }

        public ResultPage NavigateToResult()
        {
            SearchTextBox.SendKeys("BB ki Vines");
            SearchButton.Click();
            return new ResultPage(driver);
        }

    }
}
