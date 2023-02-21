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
    public class SearchItem
    {
        [TestMethod]
        public void TA_SearchItem()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://www.adrionltd.com/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"desktop-header\"]/div[1]")));

            IWebElement cookies = driver.FindElement(By.XPath("//*[@id=\"iqitcookielaw-accept\"]"));
            cookies.Click();


            //Search

            IWebElement Searchbar = driver.FindElement(By.XPath("//*[@id=\"search_widget\"]/form/div[1]/input"));
            Searchbar.Click();
            Searchbar.SendKeys("Dune");

            IWebElement Searchbutton = driver.FindElement(By.XPath("//*[@id=\"search_widget\"]/form/div[1]/button/i"));
            Searchbutton.Click();

            WebDriverWait wait4 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait4.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"js-product-list\"]/div[1]/div[3]/article/div[1]/a/img")));

            IWebElement Item = driver.FindElement(By.XPath("//*[@id=\"js-product-list\"]/div[1]/div[3]/article/div[1]/a/img"));
            Item.Click();

            WebDriverWait wait5 = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            wait5.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"main-product-wrapper\"]/div[1]/div[2]")));

            Assert.AreEqual("Dune-Adrion LTD", driver.Title);
            Thread.Sleep(4000);
            driver.Dispose();

        }
    }
}
