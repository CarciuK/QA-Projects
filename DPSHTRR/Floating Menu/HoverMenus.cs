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
    public class HoverMenus
    {
        [TestMethod]
        public void TA_HoverMenus()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://www.dpshtrr.al/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"edit-search-block-form--2\"]")));


            //Floating menu 1 Mjeti
            IWebElement hoverable1 = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[1]"));
            new Actions(driver)
                .MoveToElement(hoverable1)
                .Perform();

            //var Mjete = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[1]"));
            //Actions actions = new Actions(driver);
            //actions.MoveToElement(Mjete);
            //actions.Perform();

            Thread.Sleep(1000);

            //Floating menu 2 Leje Drejtimi 

            IWebElement hoverable2 = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[2]/a"));
            new Actions(driver)
                .MoveToElement(hoverable2)
                .Perform();


            //var LejeDrejtimi = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[2]/a"));
            //Actions actions1 = new Actions(driver);
            //actions1.MoveToElement(LejeDrejtimi);
            //actions1.Perform();


            Thread.Sleep(1000);

            //Floating menu 3 certifikata
            IWebElement hoverable3 = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[3]/a"));
            new Actions(driver)
                .MoveToElement(hoverable3)
                .Perform();

            //var Certifikata = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[3]/a"));
            //Actions actions2 = new Actions(driver);
            //actions2.MoveToElement(Certifikata);
            //actions2.Perform();

            Thread.Sleep(1000);
            //Floating menu 4 Sherbim
            IWebElement hoverable4 = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[4]/a"));
            new Actions(driver)
                .MoveToElement(hoverable4)
                .Perform();


            //var Sherbim = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[4]/a"));
            //Actions actions3 = new Actions(driver);
            //actions3.MoveToElement(Sherbim);
            //actions3.Perform();     


            Thread.Sleep(1000);
            //Floating menu 5 Projekte
            IWebElement hoverable5 = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[5]/a"));
            new Actions(driver)
                .MoveToElement(hoverable5)
                .Perform();


            //var Projekte = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[5]/a"));
            //Actions actions4 = new Actions(driver);
            //actions4.MoveToElement(Projekte);
            //actions4.Perform();



            Thread.Sleep(1000);
            //Floating menu 6 Reja

            IWebElement hoverable6 = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[6]/span[1]"));
            new Actions(driver)
                .MoveToElement(hoverable6)
                .Perform();


            //var TeReja = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[6]/span[1]"));
            //Actions actions5 = new Actions(driver);
            //actions5.MoveToElement(TeReja);
            //actions5.Perform();





            Thread.Sleep(4000);
            driver.Dispose();

        }
    }
}
