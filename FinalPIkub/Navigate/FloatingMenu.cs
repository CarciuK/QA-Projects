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
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace FinalProjectIkub
{
    [TestClass]
    public class FloatingMenu
    {
        [TestMethod]
        public void TA_FloatingMenu()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://www.adrionltd.com/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"desktop-header\"]/div[1]")));

            IWebElement cookies = driver.FindElement(By.XPath("//*[@id=\"iqitcookielaw-accept\"]"));
            cookies.Click();

            //Floating menu

            //Architecture
           IWebElement categories = driver.FindElement(By.XPath("//*[@id=\"cbp-hrmenu-tab-10\"]/a"));
           IWebElement subcategories = driver.FindElement(By.XPath("//*[@id=\"cbp-hrmenu-tab-10\"]/div/div/div/div[1]/div[1]/div/div/div[1]/div/a"));
         
            Actions action = new Actions(driver);
            action.MoveToElement(categories).Perform();
            action.MoveToElement(subcategories).Click().Perform();
           
            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"left-column\"]/div[1]")));

            IWebElement Home = driver.FindElement(By.XPath("//*[@id=\"cbp-hrmenu-tab-1\"]/a"));
            Home.Click();
            WebDriverWait wait5 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait5.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"desktop-header\"]/div[1]")));
           
            //Bussiness
            IWebElement categories1 = driver.FindElement(By.XPath("//*[@id=\"cbp-hrmenu-tab-10\"]/a"));
            IWebElement subcategories1 = driver.FindElement(By.XPath("//*[@id=\"cbp-hrmenu-tab-10\"]/div/div/div/div[1]/div[1]/div/div/div[2]/div/a"));

            Actions action1 = new Actions(driver);
            action1.MoveToElement(categories1).Perform();
            action1.MoveToElement(subcategories1).Click().Perform();

            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"left-column\"]/div[1]/h5")));















            Thread.Sleep(7000);
            driver.Dispose();

        }
    }
}