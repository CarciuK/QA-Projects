using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DPSHTRR.News
{
    [TestClass]
    public class Prokurime
    {
        [TestMethod]
        public void TA_Prokurime()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://www.dpshtrr.al/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"edit-search-block-form--2\"]")));


            //Menu 1 Te rejat
            Thread.Sleep(2000);
            var TeReja = driver.FindElement(By.XPath(" //*[@id=\"dexp-dropdown\"]/ul/li[6]"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(TeReja);
            actions.Perform();

            Thread.Sleep(2000);
            var ProkurimeE = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[6]/ul/li[2]/a"));
            Actions actions1 = new Actions(driver);
            actions1.MoveToElement(ProkurimeE);
            actions1.Click();
            actions1.Perform();


            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[3]/section[3]")));





            //Click butonin "Lexo me shume" te artikullit te pare
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("document.querySelector(\"#block-system-main > div.content > div > div > ul > li.lajm.first.odd > div > span > div > div > div.col-xs-12.col-sm-12.col-md-6.col-lg-6.col-lg-push-1.col-md-push-1 > p > a\").click()");


            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"section-main-content\"]")));




            //Assert te titullit
            Thread.Sleep(2000);
            String ExpectedText = "Për marrjen me qira të një ambienti të përshtatshëm dhe me hapësira të nevojshme në Tiranë, për të kryer provat praktike.";
            String actualtitle = driver.FindElement(By.XPath("//*[@id=\"node-2703\"]/div/div[1]/div/div/h3")).Text.ToString();
            Assert.AreEqual(ExpectedText, actualtitle);

            Thread.Sleep(4000);
            driver.Dispose();



        }
    }
}