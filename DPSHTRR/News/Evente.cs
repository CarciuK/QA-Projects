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

namespace DPSHTRR.News
{
    [TestClass]
    public class Evente
    {
        [TestMethod]
        public void TA_Evente()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://www.dpshtrr.al/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"edit-search-block-form--2\"]")));


            //Menu 1 Te rejat
            //Metoda e vjeter
            //Thread.Sleep(2000);
            //var TeReja = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[6]"));
            //Actions actions = new Actions(driver);
            //actions.MoveToElement(TeReja);
            //actions.Perform();

            //Thread.Sleep(2000);
            //var Events = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[6]/ul/li[1]/a"));
            //Actions actions1 = new Actions(driver);
            //actions1.MoveToElement(Events);
            //actions1.Click();
            //actions1.Perform();


            //Metoda e re-Hoverable
            //Menuja Te rejat-Evente
            IWebElement hoverable1 = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[6]"));
            new Actions(driver)
                .MoveToElement(hoverable1)
                .Perform();

            Thread.Sleep(1000);
            IWebElement hoverable2 = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[6]/ul/li[1]/a"));
            new Actions(driver)
                .MoveToElement(hoverable2)
                .Click()
                .Perform();


            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"block-system-main\"]/div[2]/div/div[1]/ul/li[1]/div/span/div/div")));


            //Scroll at the end of the page
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver; js.ExecuteScript("window.scrollBy(0,1400)");



            //assert i titullit
            Thread.Sleep(2000);
            String ExpectedText = "Siguria Rrugore me Vogëlushët e Shtëpisë së Fëmijës Vlorë";
            String actualtitle = driver.FindElement(By.XPath("//*[@id=\"block-system-main\"]/div[2]/div/div[1]/ul/li[4]/div/span/div/div/div[2]/h3/a")).Text.ToString();
            Assert.AreEqual(ExpectedText, actualtitle);






            Thread.Sleep(4000);
            driver.Dispose();



        }
    }
}