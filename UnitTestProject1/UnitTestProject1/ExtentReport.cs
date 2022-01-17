using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestFixture]
    public class ExtentReport
    {
        ExtentReports extent = null;


        [OneTimeSetUp]
         public void ExtentStart()
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"E:\ExtentReports\reports.html");
            extent.AttachReporter(htmlReporter);

        }

        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush(); 
        }
        [Test]
        public void Test1()
        {
            IWebDriver driver = null;
            ExtentTest test = null;
            try
            {

                 test = extent.CreateTest("Test1").Info("Test Started");
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                test.Log(Status.Info, "Chrome Browser Launched");
                driver.Url = "https://www.facebook.com";
                IWebElement emailElement = driver.FindElement(By.XPath(".//*[@id='email']"));
                emailElement.SendKeys("Aman");
                test.Log(Status.Info, "Id entered");
                
                driver.Quit();
                test.Log(Status.Info, "Test1 passed");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                throw;
            }
            finally
            {
                if(driver != null)
                {
                    driver.Quit();
                }
            }


        }

        [Test]
        public void Test2()
        {
            IWebDriver driver = null;
            ExtentTest test = null;
            try
            {

                test = extent.CreateTest("Test2").Info("Test Started");
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                test.Log(Status.Info, "Chrome Browser Launched");
                driver.Url = "https://www.facebook.com";
                IWebElement emailElement = driver.FindElement(By.XPath(".//*[@id='bhjdbdsha']"));
                emailElement.SendKeys("Aman");
                test.Log(Status.Info, "Id entered");

                driver.Quit();
                test.Log(Status.Info, "Test1 passed");

            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, ex.ToString());
                Console.WriteLine(ex.StackTrace);
                throw;
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }


        }


    }
}
