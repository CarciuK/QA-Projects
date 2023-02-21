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
    public class DropDownMenu
    {
        [TestMethod]
        public void TA_DropDownMenu()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body")));

            IWebElement DropDownMenu = driver.FindElement(By.XPath("//*[@id=\"content\"]/ul/li[11]/a"));
            DropDownMenu.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body")));

            Thread.Sleep(2000);

            IWebElement Select = driver.FindElement(By.XPath("//*[@id=\"dropdown\"]"));
            SelectElement selector = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"dropdown\"]")));
            selector.SelectByValue("2");



            Thread.Sleep(4000);
            driver.Dispose();
        }
    }
}