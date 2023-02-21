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
    public class SearchLajme
    {
        [TestMethod]
        public void TA_SearchLajme()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://www.dpshtrr.al/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"edit-search-block-form--2\"]")));


            //Menu 1 Te rejat
            IWebElement hoverable1 = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[6]"));
            new Actions(driver)
                .MoveToElement(hoverable1)
                .Perform();

            //Lajme click
            Thread.Sleep(1000);
            IWebElement hoverable2 = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[6]/ul/li[5]/a"));
            hoverable2.Click();


            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"views-exposed-form-lajme-page\"]/div/div/div")));

            //Searchbar 
            IWebElement Searchbar = driver.FindElement(By.Id("edit-keys"));
            Searchbar.SendKeys("Zëri Yt Dëgjohet për Muajin Tetor");
            //SendKeys.SendWait(@"{Enter}");


            //Search button click
            var Searchbarbtn = driver.FindElement(By.Id("edit-submit-lajme"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(Searchbarbtn).Click().Perform();


            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"block-system-main\"]/div[2]/div/div[2]/ul/li/div/span/div/div")));



            //IF condition-Clear searchbar
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"block-system-main\"]/div[2]/div/div[2]/ul/li/div/span/div/div/div[2]/h3/a"));
            if (element.Displayed)
            {
                IWebElement searchbarclear = driver.FindElement(By.XPath("//*[@id=\"edit-keys\"]"));
                searchbarclear.Clear();
               

            }
           
            //Assert
            Thread.Sleep(1000);
            String ExpectedText = "Zëri Yt Dëgjohet për Muajin Tetor";
            String actualtitle = driver.FindElement(By.XPath("//*[@id=\"block-system-main\"]/div[2]/div/div[2]/ul/li/div/span/div/div/div[2]/h3/a")).Text.ToString();
            Assert.AreEqual(ExpectedText, actualtitle);



            Thread.Sleep(5000);
            driver.Dispose();

        }
    }
}
