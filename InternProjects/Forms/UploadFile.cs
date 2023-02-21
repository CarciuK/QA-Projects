using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace InternProjects.Forms
{
    [TestClass]
    public class UploadFile
    {
        [TestMethod]
        public void TA_UploadFile()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body")));

            IWebElement UploadFile = driver.FindElement(By.XPath("//*[@id=\"content\"]/ul/li[18]/a"));
            UploadFile.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"content\"]")));



            //Upload 
            string path = @"C:\Users\carci\Desktop\Scanned Documents.pdf";
            driver.FindElement(By.XPath("//*[@id=\"file-upload\"]")).SendKeys(path);
            
            Thread.Sleep(5000);
            SendKeys.SendWait(path);
            SendKeys.SendWait(@"{Enter}");


            IWebElement Upload = driver.FindElement(By.XPath("//*[@id=\"file-submit\"]"));
            Upload.Click();

            Thread.Sleep(4000);

            Thread.Sleep(4000);
            driver.Dispose();
        }
    }
}
