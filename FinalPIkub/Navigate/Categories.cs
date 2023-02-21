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

namespace FinalProjectIkub
{
    [TestClass]
    public class Categories
    {
        [TestMethod]
        public void TA_Categories()
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


            //Dropdows
            IWebElement Dropdown1 = driver.FindElement(By.XPath("//*[@id=\"js-product-list-top\"]/div/div[3]/div[1]/a"));
            Dropdown1.Click();
            IWebElement Rendesia = driver.FindElement(By.XPath("//*[@id=\"js-product-list-top\"]/div/div[3]/div[1]/div/a[1]"));
            Rendesia.Click();
            WebDriverWait wait6 = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            wait6.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"js-product-list\"]/div[1]/div[1]")));


            IWebElement Classic1 = driver.FindElement(By.XPath("//*[@id=\"wrapper\"]/nav/div/div/div[1]/ol/li[4]/a"));
            Classic1.Click();
            WebDriverWait wait7 = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            wait7.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"content-wrapper\"]")));


            IWebElement Dropdown2 = driver.FindElement(By.XPath("//*[@id=\"js-product-list-top\"]/div/div[3]/div[1]/a"));
            Dropdown2.Click();
            IWebElement EmriAZ = driver.FindElement(By.XPath("//*[@id=\"js-product-list-top\"]/div/div[3]/div[1]/div/a[2]"));
            EmriAZ.Click();
            WebDriverWait wait8 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait8.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"js-product-list\"]/div[1]/div[1]/article/div[1]/a/img")));

            IWebElement Classic2 = driver.FindElement(By.XPath("//*[@id=\"wrapper\"]/nav/div/div/div[1]/ol/li[4]/a"));
            Classic2.Click();
            WebDriverWait wait9 = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            wait9.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"content-wrapper\"]")));

            IWebElement Dropdown3 = driver.FindElement(By.XPath("//*[@id=\"js-product-list-top\"]/div/div[3]/div[1]/a"));
            Dropdown3.Click();
            IWebElement EmriZA = driver.FindElement(By.XPath("//*[@id=\"js-product-list-top\"]/div/div[3]/div[1]/div/a[3]"));
            EmriZA.Click();
            WebDriverWait wait10 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait10.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"js-product-list\"]/div[1]/div[1]/article/div[1]/a/img")));

            IWebElement Classic3 = driver.FindElement(By.XPath("//*[@id=\"wrapper\"]/nav/div/div/div[1]/ol/li[4]/a"));
            Classic3.Click();
            WebDriverWait wait11 = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            wait11.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"content-wrapper\"]")));


            IWebElement Dropdown4 = driver.FindElement(By.XPath("//*[@id=\"js-product-list-top\"]/div/div[3]/div[1]/a"));
            Dropdown4.Click();
            IWebElement CmimiUL = driver.FindElement(By.XPath("//*[@id=\"js-product-list-top\"]/div/div[3]/div[1]/div/a[4]"));
            CmimiUL.Click();
            WebDriverWait wait12 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait12.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"js-product-list\"]/div[1]/div[1]/article/div[1]/a/img")));

            IWebElement Classic4 = driver.FindElement(By.XPath("//*[@id=\"wrapper\"]/nav/div/div/div[1]/ol/li[4]/a"));
            Classic4.Click();
            WebDriverWait wait13 = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            wait13.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"content-wrapper\"]")));


            IWebElement Dropdown5 = driver.FindElement(By.XPath("//*[@id=\"js-product-list-top\"]/div/div[3]/div[1]/a"));
            Dropdown5.Click();
            IWebElement CmimiLU = driver.FindElement(By.XPath("//*[@id=\"js-product-list-top\"]/div/div[3]/div[1]/div/a[5]"));
            CmimiLU.Click();
            WebDriverWait wait14 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait14.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"js-product-list\"]/div[1]/div[1]/article/div[1]/a/img")));

            //Dropdown 2
             




            //Assert.AreEqual("Llogaria ime", driver.Title);
            Thread.Sleep(7000);
            driver.Dispose();



        }
    }
}
