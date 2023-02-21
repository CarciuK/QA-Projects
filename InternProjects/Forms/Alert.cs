using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InternProjects.Forms
{
    [TestClass]
    public class Alert
    {
        [TestMethod]
        public void TA_Alert()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://testautomationpractice.blogspot.com/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[4]/div[2]/div[2]/div[2]/div[2]/div[2]/div[2]")));

            IWebElement Alertbutton = driver.FindElement(By.XPath("//*[@id=\"HTML9\"]/div[1]/button"));
            Alertbutton.Click();

            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();




            Thread.Sleep(4000);
            driver.Dispose();
        }
    }
}
