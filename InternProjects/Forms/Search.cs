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

namespace InternProjects.Forms
{
    [TestClass]
    public class Search
    {
        [TestMethod]
        public void TA_Search()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://testautomationpractice.blogspot.com/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[4]/div[2]/div[2]/div[2]/div[2]/div[2]/div[2]")));

            IWebElement Searchbar = driver.FindElement(By.XPath("//*[@id=\"Wikipedia1_wikipedia-search-input\"]"));
            Searchbar.Click();
            Searchbar.SendKeys("Youtube");

            IWebElement Searchbutton = driver.FindElement(By.XPath("//*[@id=\"Wikipedia1_wikipedia-search-form\"]/div/span[2]/span[2]/input"));
            Searchbutton.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"wikipedia-search-result-link\"]/a")));



            Thread.Sleep(5000);
            driver.Dispose();

        }
    }
}
