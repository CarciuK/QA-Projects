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

namespace FinalProjectIkub
{
    [TestClass]
    public class HeaderLinksL
    {
        [TestMethod]
        public void TA_HeaderLinks()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://www.adrionltd.com/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"desktop-header\"]/div[1]")));

            IWebElement cookies = driver.FindElement(By.XPath("//*[@id=\"iqitcookielaw-accept\"]"));
            cookies.Click();
          

            //Header links 

            IWebElement ForeignBooks = driver.FindElement(By.XPath("//*[@id=\"cbp-hrmenu-tab-10\"]/a"));
            ForeignBooks.Click();
            WebDriverWait wait4 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait4.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"left-column\"]/div[1]")));

            IWebElement Home = driver.FindElement(By.XPath("//*[@id=\"cbp-hrmenu-tab-1\"]/a"));
            Home.Click();
            WebDriverWait wait5 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait5.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"desktop-header\"]/div[1]")));

            //Albanian books
            IWebElement AlbanianBooks = driver.FindElement(By.XPath("//*[@id=\"cbp-hrmenu-tab-22\"]/a"));
            AlbanianBooks.Click();
            WebDriverWait wait6 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait6.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"left-column\"]/div[1]/h5")));

            IWebElement Home1 = driver.FindElement(By.XPath("//*[@id=\"cbp-hrmenu-tab-1\"]/a"));
            Home1.Click();
            WebDriverWait wait7 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait7.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"desktop-header\"]/div[1]")));

            //Revista
            IWebElement Revista = driver.FindElement(By.XPath("//*[@id=\"cbp-hrmenu-tab-25\"]/a"));
            Revista.Click();
            WebDriverWait wait8 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait8.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"left-column\"]/div[1]")));

            IWebElement Home2 = driver.FindElement(By.XPath("//*[@id=\"cbp-hrmenu-tab-1\"]/a"));
            Home2.Click();
            WebDriverWait wait9 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait9.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"desktop-header\"]/div[1]")));

            //Accessories
            IWebElement Gifts = driver.FindElement(By.XPath("//*[@id=\"cbp-hrmenu-tab-34\"]/a"));
            Gifts.Click();
            WebDriverWait wait10 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait10.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"wrapper\"]")));

            IWebElement Home3 = driver.FindElement(By.XPath("//*[@id=\"cbp-hrmenu-tab-1\"]/a"));
            Home3.Click();
            WebDriverWait wait11 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait11.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"desktop-header\"]/div[1]")));

            //Gazeta
            IWebElement Gazeta = driver.FindElement(By.XPath("//*[@id=\"cbp-hrmenu-tab-11\"]/a"));
            Gazeta.Click();
            WebDriverWait wait12 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait12.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"content-wrapper\"]")));

            IWebElement Home4 = driver.FindElement(By.XPath("//*[@id=\"cbp-hrmenu-tab-1\"]/a"));
            Home4.Click();
            WebDriverWait wait13 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait13.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"desktop-header\"]/div[1]")));

            //Sherbime
            IWebElement Sherbime = driver.FindElement(By.XPath("//*[@id=\"cbp-hrmenu-tab-16\"]/a"));
            Sherbime.Click();
            WebDriverWait wait14 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait14.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"elementor-section-wrap\"]/div[1]/div/div/div[1]/div")));

            IWebElement Home5 = driver.FindElement(By.XPath("//*[@id=\"cbp-hrmenu-tab-1\"]/a"));
            Home5.Click();
            WebDriverWait wait15 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait15.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"desktop-header\"]/div[1]")));

            //Autore
            IWebElement Autore = driver.FindElement(By.XPath("//*[@id=\"cbp-hrmenu-tab-12\"]/a"));
            Autore.Click();
            WebDriverWait wait16 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait16.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"main\"]")));

            IWebElement Home6 = driver.FindElement(By.XPath("//*[@id=\"cbp-hrmenu-tab-1\"]/a"));
            Home6.Click();
            WebDriverWait wait17 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait17.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"desktop-header\"]/div[1]")));


            //Botues
            IWebElement Botues = driver.FindElement(By.XPath("//*[@id=\"cbp-hrmenu-tab-23\"]/a"));
            Botues.Click();
            WebDriverWait wait18 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait18.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"wrapper\"]")));

            IWebElement Home7 = driver.FindElement(By.XPath("//*[@id=\"cbp-hrmenu-tab-1\"]/a"));
            Home7.Click();
            WebDriverWait wait19 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait19.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"desktop-header\"]/div[1]")));

            //Blog
            IWebElement Blog = driver.FindElement(By.XPath("//*[@id=\"cbp-hrmenu-tab-14\"]/a"));
            Blog.Click();
            WebDriverWait wait20 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait20.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"content-wrapper\"]/div/ul/li/div/div/div")));

            IWebElement Home8 = driver.FindElement(By.XPath("//*[@id=\"cbp-hrmenu-tab-1\"]/a"));
            Home8.Click();
            WebDriverWait wait21 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait21.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"desktop-header\"]/div[1]")));

            Assert.AreEqual("ADRION Ltd - Libraria më e madhe në Shqipëri", driver.Title);


            //Thread.Sleep(7000);
            driver.Dispose();
        }
    }
}
