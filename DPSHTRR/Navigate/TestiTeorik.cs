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
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace DPSHTRR.Navigate
{
    [TestClass]
    public class TestiTeorik
    {
        [TestMethod]
        public void TA_TestiTeorik()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://www.dpshtrr.al/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"edit-search-block-form--2\"]")));

            IWebElement TestiTeorik = driver.FindElement(By.XPath("//*[@id=\"block-block-127\"]/div[2]/div/div[3]/a[1]"));
            TestiTeorik.Click();

            WebDriverWait wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait3.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"block-block-134\"]/div[2]/div/div/div[1]/div/div/a/img")));


            //Scroll te elementi 
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver; js.ExecuteScript("window.scrollBy(0,290)");


            //Klikojme butonin shfleto
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("document.querySelector(\"#block-block-134 > div.content > div > div > div:nth-child(1) > div > p > a\").click()");


            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"section-main-content\"]/div/div/div")));
            Thread.Sleep(8000);

            //Switch to iframe-i i librit
            IWebElement iframe = driver.FindElement(By.XPath("//*[@id=\"node-18567\"]/div/div/div/div/iframe"));
            driver.SwitchTo().Frame(iframe);

            Thread.Sleep(4000);


            //Klikojme next button        
            IWebElement NextBTN = driver.FindElement(By.XPath("//*[@id=\"secondaryToolbarToggle\"]"));
            NextBTN.Click();


            //Shko ne faqen e fundit
            IWebElement LastpageBTN = driver.FindElement(By.XPath("//*[@id=\"lastPage\"]"));
            LastpageBTN.Click();

            WebDriverWait wait4 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait4.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"viewer\"]/div[215]/div[2]")));

            //Assert fjaline e pare te faqes se fundit
            Thread.Sleep(2000);
            String ExpectedText = "Kërkesa për dëmshpërblim mund të paraqitet brenda dy vitesh nga momenti ";
            String ActualText = driver.FindElement(By.XPath("//*[@id=\"viewer\"]/div[215]/div[2]/div[2]")).Text.ToString();
            Assert.AreEqual(ExpectedText, ActualText);

            Thread.Sleep(5000);
            driver.Dispose();



        }
    }
}