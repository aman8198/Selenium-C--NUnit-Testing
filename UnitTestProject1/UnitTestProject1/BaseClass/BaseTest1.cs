using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.BaseClass
{
    public class BaseTest1
    {
        public IWebDriver driver;

        [SetUp]
        public void Start()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.youtube.com";
        }

        [TearDown]
        public void End()
        {
            driver.Quit();
        }
    }
}
