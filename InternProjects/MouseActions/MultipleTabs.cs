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

namespace InternProjects.MouseActions
{
    [TestClass]
    public class MultipleTabs
    {
        [TestMethod]
        public void TA_MultipleTabs()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body")));

            IWebElement Multipletabs = driver.FindElement(By.XPath("//*[@id=\"content\"]/ul/li[33]/a"));
            Multipletabs.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"content\"]/div")));

            IWebElement Clicktab = driver.FindElement(By.XPath("//*[@id=\"content\"]/div/a"));
            Clicktab.Click();


            //Switch to other tabs

            driver.SwitchTo().Window(driver.WindowHandles[1]);

            Thread.Sleep(3000);
            driver.SwitchTo().Window(driver.WindowHandles[0]);

            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"content\"]/div/a")));

            Thread.Sleep(4000);
            driver.Dispose();



        }
    }
}