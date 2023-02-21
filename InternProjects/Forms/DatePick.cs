using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InternProjects.Forms
{
    [TestClass]
    public class DatePick
    {
        [TestMethod]
        public void TA_DatePick()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://testautomationpractice.blogspot.com/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[4]/div[2]/div[2]/div[2]/div[2]/div[2]/div[2]")));

            IWebElement Datebutton = driver.FindElement(By.XPath("//*[@id=\"datepicker\"]"));
            Datebutton.Click();
            Datebutton.SendKeys("11/10/2021");
            Thread.Sleep(1000);

            //Clicking month button manually

            //IWebElement Month = driver.FindElement(By.XPath("//*[@id=\"ui-datepicker-div\"]/div/a[2]/span"));
            //Month.Click();
            //IWebElement Month1 = driver.FindElement(By.XPath("//*[@id=\"ui-datepicker-div\"]/div/a[2]/span"));
            //Month1.Click();
            
            //Thread.Sleep(5000);
            //IWebElement Date = driver.FindElement(By.XPath("//*[@id=\"ui-datepicker-div\"]/table/tbody/tr[3]/td[4]/a"));
            //Date.Click();
            
           


            Thread.Sleep(5000);
            driver.Dispose();


        }
    }
}
