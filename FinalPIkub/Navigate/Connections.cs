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
    public class Connections
    {
        [TestMethod]
        public void TA_Connections()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://www.adrionltd.com/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"desktop-header\"]/div[1]")));

            IWebElement cookies = driver.FindElement(By.XPath("//*[@id=\"iqitcookielaw-accept\"]"));
            cookies.Click();

            //Facebook
            IWebElement Facebook = driver.FindElement(By.XPath("//*[@id=\"footer-container-main\"]/div/div[2]/div[4]/div[1]/div/ul/li[1]/a"));
            Facebook.Click();

            driver.SwitchTo().Window(driver.WindowHandles[1]);

            Thread.Sleep(4000);
            driver.SwitchTo().Window(driver.WindowHandles[0]);

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"footer-container-main\"]/div/div[2]/div[4]")));

            //Instagram
            IWebElement Instagram = driver.FindElement(By.XPath("//*[@id=\"footer-container-main\"]/div/div[2]/div[4]/div[1]/div/ul/li[2]/a"));
            Instagram.Click();

            driver.SwitchTo().Window(driver.WindowHandles[2]);


            Thread.Sleep(5000);
            driver.SwitchTo().Window(driver.WindowHandles[0]);

            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"footer-container-main\"]/div/div[2]/div[4]")));


            Thread.Sleep(5000);
            //Assert.AreEqual("Identiteti", driver.Title);
            driver.Dispose();


        }
    }
}