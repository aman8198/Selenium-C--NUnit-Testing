using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.BaseClass
{
    public class BaseTest
    {
        //2nd part onetimesetup and onetimeteardown attribute implementation
        //3rd part setup and teardown attribute implementation
        public IWebDriver driver;
        [OneTimeSetUp]
        //[SetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";
            
        }
        [OneTimeTearDown]
        //[TearDown]
        public void Close()
        {
            driver.Quit();

        }
    }
}
