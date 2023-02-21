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
    public class FooterLinks
    {
        [TestMethod]
        public void TA_FooterLinks()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://www.adrionltd.com/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"desktop-header\"]/div[1]")));

            IWebElement cookies = driver.FindElement(By.XPath("//*[@id=\"iqitcookielaw-accept\"]"));
            cookies.Click();

            //IWebElement newsletter = driver.FindElement(By.XPath("//*[@id=\"ff_newsletter\"]"));
            //newsletter.Click();

            //ShoppingWithUs
            IWebElement ClientsCard = driver.FindElement(By.XPath("//*[@id=\"footer-container-main\"]/div/div[2]/div[1]/div/ul/li[1]/a"));
            ClientsCard.Click();
            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"main\"]")));

            IWebElement Home = driver.FindElement(By.XPath("//*[@id=\"cbp-hrmenu-tab-1\"]/a"));
            Home.Click();
            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"desktop-header\"]/div[1]")));

            IWebElement GiftCard = driver.FindElement(By.XPath("//*[@id=\"footer-container-main\"]/div/div[2]/div[1]/div/ul/li[2]/a"));
            GiftCard.Click();
            WebDriverWait wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait3.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"main\"]")));

            IWebElement Home1 = driver.FindElement(By.XPath("//*[@id=\"cbp-hrmenu-tab-1\"]/a"));
            Home1.Click();
            WebDriverWait wait4 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait4.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"desktop-header\"]/div[1]")));


            IWebElement AdrionPlus = driver.FindElement(By.XPath("//*[@id=\"footer-container-main\"]/div/div[2]/div[1]/div/ul/li[3]/a"));
            AdrionPlus.Click();
            WebDriverWait wait5 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait5.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"main\"]")));

            //Customer Services
            IWebElement Home2 = driver.FindElement(By.XPath("//*[@id=\"cbp-hrmenu-tab-1\"]/a"));
            Home2.Click();
            WebDriverWait wait6 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait6.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"desktop-header\"]/div[1]")));

            

            IWebElement Help = driver.FindElement(By.XPath("//*[@id=\"footer-container-main\"]/div/div[2]/div[2]/div/ul/li[1]/a"));
            Help.Click();
            WebDriverWait wait7 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait7.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"main\"]")));

            IWebElement Home3 = driver.FindElement(By.XPath("//*[@id=\"cbp-hrmenu-tab-1\"]/a"));
            Home3.Click();
            WebDriverWait wait8 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait8.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"desktop-header\"]/div[1]")));

            IWebElement Delivery = driver.FindElement(By.XPath("//*[@id=\"footer-container-main\"]/div/div[2]/div[2]/div/ul/li[2]/a"));
            Delivery.Click();
            WebDriverWait wait9 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait9.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"main\"]")));

            IWebElement Home4 = driver.FindElement(By.XPath("//*[@id=\"cbp-hrmenu-tab-1\"]/a"));
            Home4.Click();
            WebDriverWait wait10 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait10.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"desktop-header\"]/div[1]")));

            IWebElement Payment = driver.FindElement(By.XPath("//*[@id=\"footer-container-main\"]/div/div[2]/div[2]/div/ul/li[3]/a"));
            Payment.Click();
            WebDriverWait wait11 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait11.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"main\"]")));


            IWebElement Home5 = driver.FindElement(By.XPath("//*[@id=\"cbp-hrmenu-tab-1\"]/a"));
            Home5.Click();
            WebDriverWait wait12 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait12.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"desktop-header\"]/div[1]")));

            IWebElement PrivacyPolicy = driver.FindElement(By.XPath("//*[@id=\"footer-container-main\"]/div/div[2]/div[2]/div/ul/li[4]/a"));
            PrivacyPolicy.Click();
            WebDriverWait wait13 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait13.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"main\"]")));

            IWebElement Home6 = driver.FindElement(By.XPath("//*[@id=\"cbp-hrmenu-tab-1\"]/a"));
            Home6.Click();
            WebDriverWait wait14 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait14.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"desktop-header\"]/div[1]")));

            IWebElement LegalNotice = driver.FindElement(By.XPath("//*[@id=\"footer-container-main\"]/div/div[2]/div[2]/div/ul/li[5]/a"));
            LegalNotice.Click();
            WebDriverWait wait15 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait15.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"elementor-section-wrap\"]/div/div/div/div/div")));

            


            Thread.Sleep(5000);
            Assert.AreEqual("Njoftim Ligjor", driver.Title);
            driver.Dispose();
        }
    }
}