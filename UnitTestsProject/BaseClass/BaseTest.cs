using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTestsProject.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver("C:\\Program Files\\Google\\Chrome\\Application");
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/reg/";
            var button = driver.FindElement(By.XPath(".//*[@data-testid='cookie-policy-manage-dialog-accept-button'][2]"));
            button.Click();
            Thread.Sleep(1000);
        }
        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
