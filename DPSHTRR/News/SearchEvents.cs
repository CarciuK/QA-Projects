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
using System.Windows.Forms;

namespace DPSHTRR.News
{
    [TestClass]
    public class SearchEvente
    {
        [TestMethod]
        public void TA_SearchEvente()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://www.dpshtrr.al/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"edit-search-block-form--2\"]")));


            //Menu 1 Te rejat
            //Thread.Sleep(2000);
            //var TeReja = driver.FindElement(By.XPath(" //*[@id=\"dexp-dropdown\"]/ul/li[6]"));
            //Actions actions = new Actions(driver);
            //actions.MoveToElement(TeReja);
            //actions.Perform();

            //Thread.Sleep(2000);
            //var Events = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[6]/ul/li[1]/a"));
            //Actions actions1 = new Actions(driver);
            //actions1.MoveToElement(Events);
            //actions1.Click();
            //actions1.Perform();


            //WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            //wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"block-system-main\"]/div[2]/div/div[1]/ul/li[1]/div/span/div/div")));


            //Search
            IWebElement Search = driver.FindElement(By.XPath("//*[@id=\"edit-search-block-form--2\"]"));
            Search.Click();
            Search.SendKeys("Zëri Yt Dëgjohet për Muajin Tetor");
            SendKeys.SendWait(@"{Enter}");



            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"block-system-main\"]/div[2]")));

            //Assert not equal/Titulli i kerkuar nuk shfaq rezultatin 
            Thread.Sleep(2000);
            String ExpectedText = "Në Pistën Paul Ricard, Le Castellet, Francë";
            String actualtitle = driver.FindElement(By.XPath("//*[@id=\"search-form\"]")).Text.ToString();
            Assert.AreNotEqual(ExpectedText, actualtitle);






            Thread.Sleep(3000);
            driver.Dispose();



        }
    }
}
