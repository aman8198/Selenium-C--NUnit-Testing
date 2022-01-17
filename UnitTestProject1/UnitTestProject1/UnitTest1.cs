using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using UnitTestProject1.BaseClass;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1 : BaseTest
    {
        //1st part TestFixture Attribute Implementaion
        //4th part category attribute Implementation
        [Test, Category("Smoke Testing")]
        public void TestMethod()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium c#");
        }

        [Test, Category("Regression Testing")]
        public void TestMethod1()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium c#1");
        }

        [Test, Category("Smoke Testing")]
        public void TestMethod2()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium c#2");
            Thread.Sleep(5000);
        }

       

        //Handle Drop Down List Implementation
        [Test]
        public void TestMethod4()
        {
            driver.Url = "http://demo.automationtesting.in/Register.html";
            IWebElement skillDropdownList = driver.FindElement(By.XPath("//*[@id='Skills']"));
            SelectElement element = new SelectElement(skillDropdownList);
            element.SelectByIndex(1);
            Thread.Sleep(2000);
            element.SelectByText("APIs");
            Thread.Sleep(2000);
            element.SelectByValue("C");
            Thread.Sleep(5000);

        }






    }
}
