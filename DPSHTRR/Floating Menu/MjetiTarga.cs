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

namespace DPSHTRR.Floating_Menu
{
    [TestClass]
    public class TargaMjeti
    {
        [TestMethod]
        public void TA_TargaMjeti()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://www.dpshtrr.al/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"edit-search-block-form--2\"]")));


            //Floating menu 1 targa
            var Mjete = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[1]"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(Mjete);
            actions.Perform();

            Thread.Sleep(1000);

            var Targa = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[1]/ul/li[4]/a"));
            Actions actions1 = new Actions(driver);
            actions1.MoveToElement(Targa);
            actions1.Perform();

            Thread.Sleep(1000);

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[1]/ul/li[4]/ul")));


            var TargaH = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[1]/ul/li[4]/ul/li[5]/a"));
            Actions actions2 = new Actions(driver);
            actions2.MoveToElement(TargaH);
            actions2.Perform();
            //actions2.Click();

            IWebElement mjetiri = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[1]/ul/li[4]/ul/li[5]/a"));
            mjetiri.Click();

            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"section-main-content\"]/div/div")));







            Thread.Sleep(2000);
            String ExpectedText = "Humbja, Vjedhja, Shkatërrimi i Targës/Targave";
            String actualtitle = driver.FindElement(By.XPath("//*[@id=\"node-4670\"]/div/div/div/div/p[1]/strong")).Text.ToString();
            Assert.AreEqual(ExpectedText, actualtitle);





            Thread.Sleep(2000);
            driver.Dispose();

        }
    }
}
