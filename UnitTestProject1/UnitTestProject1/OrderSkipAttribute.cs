using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestFixture]
    public class OrderSkipAttribute
    {
        //4th part Ignore and Order Attribute Implementation 
        [Test, Order(0), Category("OrderSkipAttribute")]
        public void TestMethod()
        {
            Assert.Ignore("this test is ignored"); // Ignore Attribute
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("aasaKK;s;kl");
            driver.Close();
        }

        /*

        [Test, Order(1), Category("OrderSkipAttribute")]
        public void TestMethod2()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com/";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("aasaKK;s;kl");
            driver.Close();
        }*/

        [Test, Order(1), Category("OrderSkipAttribute")]
        public void TestMethod3()
        {
            var options = new InternetExplorerOptions();
            options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
         
            IWebDriver driver = new InternetExplorerDriver(options);
            driver.Url = "https://www.facebook.com/";
            /*
            IWebElement emailTextField = driver.FindElement(By.Id("email"));
            emailTextField.SendKeys("aasaKK;s;kl");
            */
            driver.Close();
        }

    }
}
