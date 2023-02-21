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
    public class LanguageCh
    {
        [TestMethod]
        public void TA_LanguageCh()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://www.adrionltd.com/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"desktop-header\"]/div[1]")));

            IWebElement cookies = driver.FindElement(By.XPath("//*[@id=\"iqitcookielaw-accept\"]"));
            cookies.Click();
          
            
            //Language

            IWebElement Language = driver.FindElement(By.XPath("//*[@id=\"language_selector\"]/div/div/a"));
            Language.Click();
            IWebElement English = driver.FindElement(By.XPath("//*[@id=\"language_selector\"]/div/div/div/ul/li[1]/a"));
            English.Click();
            WebDriverWait wait4 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait4.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"cbp-hrmenu\"]/ul")));

            //Currency
            IWebElement Currency = driver.FindElement(By.XPath("//*[@id=\"currency_selector\"]/div/a"));
            Currency.Click();
            IWebElement Euro = driver.FindElement(By.XPath("//*[@id=\"currency_selector\"]/div/div/ul/li[2]/a"));
            Euro.Click();
            WebDriverWait wait5 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait5.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"iqitmegamenu-horizontal\"]")));

            Thread.Sleep(4000);
            Assert.AreEqual("ADRION Ltd - Albania's biggest bookstore", driver.Title);
            driver.Dispose();



        }
    }
}
