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

namespace FinalProjectIkub
{
    [TestClass]
    public class Categories2
    {
        [TestMethod]
        public void TA_Categories2()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://www.adrionltd.com/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"desktop-header\"]/div[1]")));

            IWebElement cookies = driver.FindElement(By.XPath("//*[@id=\"iqitcookielaw-accept\"]"));
            cookies.Click();


            //Categories
            IWebElement ForeignBooks = driver.FindElement(By.XPath("//*[@id=\"cbp-hrmenu-tab-10\"]/a"));
            ForeignBooks.Click();
            WebDriverWait wait4 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait4.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"left-column\"]/div[1]")));

            IWebElement ForeignClassic = driver.FindElement(By.XPath("//*[@id=\"left-column\"]/div[1]/div/ul/li[4]/a"));
            ForeignClassic.Click();
            WebDriverWait wait5 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait5.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"content-wrapper\"]")));

            //Dropdown2
            IWebElement DropdownA = driver.FindElement(By.XPath("//*[@id=\"js-product-list-top\"]/div/div[3]/div[2]/a"));
            DropdownA.Click();
            IWebElement No12 = driver.FindElement(By.XPath("//*[@id=\"js-product-list-top\"]/div/div[3]/div[2]/div/a[1]"));
            No12.Click();
            WebDriverWait wait11 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait11.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"products\"]")));

            IWebElement DropdownB = driver.FindElement(By.XPath("//*[@id=\"js-product-list-top\"]/div/div[3]/div[2]/a"));
            DropdownB.Click();
            IWebElement No36 = driver.FindElement(By.XPath("//*[@id=\"js-product-list-top\"]/div/div[3]/div[2]/div/a[3]"));
            No36.Click();
            WebDriverWait wait12 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait12.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"products\"]")));

            //PageNo
            IWebElement PageNumber = driver.FindElement(By.XPath("//*[@id=\"infinity-url\"]"));
            PageNumber.Click();
            WebDriverWait wait13 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait13.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"js-product-list\"]/div[1]/div[1]/article/div[1]/a/img")));

            IWebElement PageNumberLast = driver.FindElement(By.XPath("//*[@id=\"js-product-list-top\"]/div/div[4]/nav/ul/li[6]/a"));
            PageNumberLast.Click();
            WebDriverWait wait14 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait14.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"js-product-list\"]/div[1]/div[1]/article/div[1]/a/img")));


            //Assert.AreEqual("Adrion LTD", driver.Title);
            Thread.Sleep(7000);
            driver.Dispose();
        }
    }
}