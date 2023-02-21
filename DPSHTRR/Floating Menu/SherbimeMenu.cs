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
    public class SherbimMenu
    {
        [TestMethod]
        public void TA_SherbimMenu()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://www.dpshtrr.al/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"edit-search-block-form--2\"]")));



            //Floating menu 4 Sherbim
            var Sherbim = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[4]/a"));
            Actions actions3 = new Actions(driver);
            actions3.MoveToElement(Sherbim);
            actions3.Perform();

            Thread.Sleep(2000);


            //WebDriverWait wait5 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            //wait5.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[4]/ul")));


            //Menu 2 Targa
            var TargaMenu = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[4]/ul/li[2]/a"));
            Actions actions4 = new Actions(driver);
            actions4.MoveToElement(TargaMenu);
            actions4.Perform();

            WebDriverWait wait6 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait6.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[4]/ul/li[2]/ul")));



            //Menu 3 Targa prove
            var TargeProve = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[4]/ul/li[2]/ul/li[1]/a"));
            Actions actions5 = new Actions(driver);
            actions5.MoveToElement(TargeProve).Click();
            actions5.Perform();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"node-4666\"]/div/div[1]/div/div")));




            Thread.Sleep(4000);
            driver.Dispose();


        }
    }
}
