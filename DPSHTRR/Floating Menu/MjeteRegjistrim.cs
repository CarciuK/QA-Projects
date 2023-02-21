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

namespace DPSHTRR.Floating_Menu
{
    [TestClass]
    public class RegjistrimMjeti
    {
        [TestMethod]
        public void TA_RegjistrimMjeti()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://www.dpshtrr.al/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"edit-search-block-form--2\"]")));


            //Floating menu
            //Mjete menu
            IWebElement hoverable1 = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[1]"));
            new Actions(driver)
                .MoveToElement(hoverable1)
                .Perform();

            //var Mjete = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[1]"));
            //Actions actions = new Actions(driver);
            //actions.MoveToElement(Mjete);
            //actions.Perform();

            Thread.Sleep(1000);
            //Regjistrim menu
            IWebElement hoverable2 = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[1]/ul/li[2]/a"));
            new Actions(driver)
                .MoveToElement(hoverable2)
                .Perform();

            //var Regjistrim = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[1]/ul/li[2]/a"));
            //Actions actions1 = new Actions(driver);
            //actions1.MoveToElement(Regjistrim);
            //actions1.Perform();

            Thread.Sleep(1000);

            //WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            //wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[1]/ul/li[2]/ul")));


            var MjetRi = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[1]/ul/li[2]/ul/li[1]/a"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(MjetRi).Click().Perform();
            

            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"section-main-content\"]/div/div")));




            


            Thread.Sleep(2000);
            String ExpectedText = "Për të regjistruar një mjet të ri/0 km, të paregjistruar më parë, të blerë në Shqipëri/jashtë shtetit, ju duhet:";
            String actualtitle = driver.FindElement(By.XPath("/html/body/div[3]/section[3]/div/div/div/div[2]/div[2]/div/div/div/div/div/p[1]")).Text.ToString();
            Assert.AreEqual(ExpectedText, actualtitle);





            Thread.Sleep(4000);
            driver.Dispose();

        }
    }
}