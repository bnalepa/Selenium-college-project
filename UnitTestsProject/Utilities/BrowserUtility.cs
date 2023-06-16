using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsProject.Utilities
{
    public class BrowserUtility
    {
        public IWebDriver Init(IWebDriver driver)
        {
            driver = new ChromeDriver("C:\\Program Files\\Google\\Chrome\\Application");
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/reg/";
            return driver;
        }
    }
}
