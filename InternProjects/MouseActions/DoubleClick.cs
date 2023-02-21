using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InternProjects.MouseActions
{
    [TestClass]
    public class DoubleClick
    {
        [TestMethod]
        public void TA_DoubleClick()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://testautomationpractice.blogspot.com/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[4]/div[2]/div[2]/div[2]/div[2]/div[2]/div[2]")));


            //Double click action
            Actions Button = new Actions(driver);
            IWebElement trialaction = driver.FindElement(By.XPath("//*[@id=\"HTML10\"]/div[1]/button"));
            Button.DoubleClick(trialaction).Perform();



            Thread.Sleep(4000);
            driver.Dispose();
        }
    }
}
