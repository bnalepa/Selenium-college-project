// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnitTestsProject.BaseClass;
using UnitTestsProject.Utilities;

namespace UnitTestsProject
{
    [TestFixture]
    public class OrderSkipAttribute
    {
        
        [Test, Order(2), Category("OrderSkipAttribute")]
        public void TestMethod1()
        {
            Assert.Ignore("Defect 12345");
            IWebDriver driver = new ChromeDriver("C:\\Program Files\\Google\\Chrome\\Application");
            driver.Url = "https://www.facebook.com/reg/";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@class='inputtext _58mg _5dba _2ph-']"));
            emailTextField.SendKeys("Selenium c#");
            driver.Close();
        }
        [Test, Order(1),  Category("OrderSkipAttribute")]
        public void TestMethod2()
        {

            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com/reg/";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@class='inputtext _58mg _5dba _2ph-']"));
            emailTextField.SendKeys("Selenium c#");
            driver.Close();
        }
        [Test, Order(0), Category("OrderSkipAttribute")]
        public void TestMethod3()
        {

            IWebDriver driver = new EdgeDriver();
            driver.Url = "https://www.facebook.com/reg/";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@class='inputtext _58mg _5dba _2ph-']"));
            emailTextField.SendKeys("Selenium c#");
            driver.Close();
        }


    }
}
