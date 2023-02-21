using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace InternProjects.Forms
{
    [TestClass]
    public class FileDownload
    {
        [TestMethod]
        public void TA_FileDownload()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body")));

            IWebElement FileDownl = driver.FindElement(By.XPath("//*[@id=\"content\"]/ul/li[17]/a"));
            FileDownl.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body")));

            IWebElement Textfile = driver.FindElement(By.XPath("//*[@id=\"content\"]/div/a[1]"));
            Textfile.Click();

            Thread.Sleep(6000);
            driver.Dispose();




        }
    }
}
