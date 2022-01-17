using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnitTestProject1.BaseClass;
using UnitTestProject1.Page_Object;

namespace UnitTestProject1.TestScripts
{
    [TestFixture]
    public class Module1 : BaseTest1
    {
        [Test]
        public void TestMethod1()
        {
            var searchpage = new SearchPage(driver);
            var resultpage = searchpage.NavigateToResult();
            var channelpage= resultpage.NavigateToChannel();
            string Actual= channelpage.getChannelName();
            string Expected = "BB Ki Vines";
            Assert.IsTrue(Actual.Equals(Expected));

            Thread.Sleep(10000);


        }

    }
}
