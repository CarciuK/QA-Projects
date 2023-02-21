using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPSHTRR.Navigate
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


            //Kerkojme "Mjete" ne search bar
            IWebElement Searchbar = driver.FindElement(By.XPath("//*[@id=\"edit-search-block-form--2\"]"));
            Searchbar.Click();
            Searchbar.SendKeys("Mjete");
            SendKeys.SendWait(@"{Enter}");
            
            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"section-main-content\"]/div/div")));


            //Assert titullin e pare te faqes 
            String ExpectedText = "Open Data: Statistika & Raporte";
            String ActualText = driver.FindElement(By.XPath("//*[@id=\"block-system-main\"]/div[2]/ol/li[1]/h3/a")).Text.ToString();
            Assert.AreEqual(ExpectedText, ActualText);


            Thread.Sleep(4000);
            driver.Dispose();
        }
    }
}
