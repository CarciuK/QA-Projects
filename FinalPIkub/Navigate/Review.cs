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
using System.Windows.Forms;

namespace FinalProjectIkub
{
    [TestClass]
    public class ReviewItem
    {
        [TestMethod]
        public void TA_ReviewItem()
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

            //Review
            IWebElement Review = driver.FindElement(By.XPath("//*[@id=\"product-infos-tabs\"]/li[2]/a"));
            Review.Click();
            WebDriverWait wait6 = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            wait6.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"iqit-reviews-top\"]/div")));

            IWebElement Reviewbutton = driver.FindElement(By.XPath("//*[@id=\"iqit-reviews-top\"]/div/div[2]/button"));
            Reviewbutton.Click();
            WebDriverWait wait7 = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            wait7.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"iqitreviews-productreview-form\"]/div[2]")));

            string Comment = @"Great book, fantastic story";
            driver.FindElement(By.XPath("//*[@id=\"iqitreviews_comment\"]")).SendKeys(Comment);

            Thread.Sleep(5000);
            //SendKeys.SendWait(Comment);
            SendKeys.SendWait(@"{Enter}");



            Assert.AreEqual("Dune-Adrion LTD", driver.Title);
            Thread.Sleep(4000);
            driver.Dispose();

        }
    }
}
