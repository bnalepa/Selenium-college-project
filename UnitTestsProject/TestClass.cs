// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnitTestsProject.BaseClass;

namespace UnitTestsProject
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        
        [Test,Category("Smoke Testing")]
        public void TestMethod1()
        {            
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@class='inputtext _58mg _5dba _2ph-']"));
            emailTextField.SendKeys("Selenium C#");
            IWebElement monthBirthDay = driver.FindElement(By.XPath(".//*[@id='month']"));
            SelectElement element = new SelectElement(monthBirthDay);
            element.SelectByIndex(1);   
            element.SelectByText("mar");   
            element.SelectByValue("5");   
            
        }
        [Test, Category("Regression Testing")]
        public void TestMethod2()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@class='inputtext _58mg _5dba _2ph-']"));
            emailTextField.SendKeys("Selenium base");
        }
        [Test, Category("Smoke Testing")]
        public void TestMethod3()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@class='inputtext _58mg _5dba _2ph-']"));
            emailTextField.SendKeys("Selenium base");
            Thread.Sleep(4000);
        }
    }
}
