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

namespace DPSHTRR.Navigate
{
    [TestClass]
    public class Scroll
    {
        [TestMethod]
        public void TA_Scroll()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://www.dpshtrr.al/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"edit-search-block-form--2\"]")));


            //Scroll at the end of the page
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver; js.ExecuteScript("window.scrollBy(0,2900)");


            //Assert element title
            String ExpectedText = "LIDHJE TË SHPEJTA";
            String ActualText = driver.FindElement(By.XPath("//*[@id=\"block-block-61\"]/h2")).Text.ToString();
            Assert.AreEqual(ExpectedText, ActualText);



            Thread.Sleep(4000);
            driver.Dispose();
        }
    }
}
