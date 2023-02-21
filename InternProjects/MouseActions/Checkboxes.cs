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

namespace InternProjects.MouseActions
{

    [TestClass]
    public class Checkboxes
    {
        [TestMethod]
        public void TA_Checkboxes()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body")));

            IWebElement Checkboxes = driver.FindElement(By.XPath("//*[@id=\"content\"]/ul/li[6]/a"));
            Checkboxes.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body")));

            Thread.Sleep(2000);
            IWebElement  Checkbox1 = driver.FindElement(By.XPath("//*[@id=\"checkboxes\"]/input[1]"));
            Checkbox1.Click();



            Thread.Sleep(2000);
            IWebElement Checkbox2 = driver.FindElement(By.XPath("//*[@id=\"checkboxes\"]/input[2]"));
            Checkbox2.Click();




            Thread.Sleep(4000);
            driver.Dispose();
        }
    }
}