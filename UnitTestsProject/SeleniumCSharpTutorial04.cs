using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestsProject
{
    [TestFixture]
    public class SeleniumCSharpTutorial04
    {
        [Test]
        [Author("Nalepa", "bartlomiej.nalepa@microsoft.wsei.edu.pl")]
        [Description("Facebook login verify")]
        [TestCaseSource("DataDrivenTesting")]
        public void Test1(string urlName)
        {
            IWebDriver driver = null;
            try
            {
                driver = new ChromeDriver("C:\\Program Files\\Google\\Chrome\\Application");
                driver.Manage().Window.Maximize();
                driver.Url = urlName;
                var button = driver.FindElement(By.XPath(".//*[@data-testid='cookie-policy-manage-dialog-accept-button'][2]"));
                button.Click();
                IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@class='inputtext _58mg _5dba _2ph-']"));
                emailTextField.SendKeys("Selenium c#");
                driver.Quit();
            }
            catch (Exception e)
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\Nie wiem\\source\\repos\\Selenium\\UnitTestsProject\\Screenshots\\screenshot1.jpeg", ScreenshotImageFormat.Jpeg);
                Console.WriteLine(e.StackTrace);
                    throw;
            }
            finally
            {
                if(driver!=null)
                {
                    driver.Quit();
                }
            }
            
        }

        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();
            list.Add("https://www.facebook.com/reg/");
            //list.Add("https://www.youtube.com");
            //list.Add("https://www.gmail.com");
            return list;
        }

        //[Test]
        //[Author("Nalepa", "bartlomiej.nalepa@microsoft.wsei.edu.pl")]
        //[Description("Facebook login verify")]
        //public void Test2()
        //{
        //    IWebDriver driver = new ChromeDriver("C:\\Program Files\\Google\\Chrome\\Application");
        //    driver.Url = "https://www.facebook.com/reg/";
        //    var button = driver.FindElement(By.XPath(".//*[@data-testid='cookie-policy-manage-dialog-accept-button'][2]"));
        //    button.Click();
        //    IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@class='inputtext _58mg _5dba _2ph-']"));
        //    emailTextField.SendKeys("Selenium c#");
        //    driver.Quit();
        //}


    }
}
