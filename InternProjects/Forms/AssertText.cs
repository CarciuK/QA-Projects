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

namespace InternProjects.Forms
{
    [TestClass]
    public class AssertText
    {
        [TestMethod]
        public void TA_AssertText()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://testautomationpractice.blogspot.com/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[4]/div[2]/div[2]/div[2]/div[2]/div[2]/div[2]")));

            var element = driver.FindElement(By.XPath("//*[@id=\"Text1\"]/div[1]/div[5]/span"));
            Actions actions1 = new Actions(driver);
            actions1.MoveToElement(element);
            actions1.Perform();

            Thread.Sleep(2000);


            String ExpectedText = "Message-123";
            String actualtitle = driver.FindElement(By.XPath("//*[@id=\"Text1\"]/div[1]/div[1]/span")).Text.ToString();
            Assert.AreEqual(ExpectedText, actualtitle);


            Thread.Sleep(4000);
            driver.Dispose();
        }
    }
}