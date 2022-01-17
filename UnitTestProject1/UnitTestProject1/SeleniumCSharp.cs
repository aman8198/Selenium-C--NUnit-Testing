using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    //Use of Author and Description Attribute
    [TestFixture]
    public class SeleniumCSharp
    {
        [Test]
        [Category("Completed By Aman")]
        [Author("Aman", "jhaaman8198@gmail.com")]
        [Description("Facebook")]
        [TestCaseSource("DataDrivenTesting")]
        public void TestMethod1(string urlname)
        {
           IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            // driver.Url = "https://www.facebook.com/";
            driver.Url = urlname;
            /*
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium c#");
            */
            driver.Quit();

        }

        [Test]
        [TestCaseSource("DataDrivenTesting")]
        public void TestMethod2(String urlname)
        {
            IWebDriver driver = null;
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Url = urlname;
                IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
                emailTextField.SendKeys("Selenium c#");
                driver.Quit();
            }catch(Exception ex)
            {
                ITakesScreenshot takesScreenshot = driver as ITakesScreenshot;
                Screenshot screenshot = takesScreenshot.GetScreenshot();
                screenshot.SaveAsFile("E:\\Screenshots\\ash.jpeg");
                Console.WriteLine(ex.StackTrace);
                throw;
            }
            finally
            {
                if(driver == null)
                {
                    driver.Quit();
                }
            }
        }

        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();
            list.Add("https://www.facebook.com/");
            list.Add("https://www.youtube.com/");
            list.Add("https://www.google.com/");
            return list;

        }
    }
}
