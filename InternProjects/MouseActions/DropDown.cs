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

namespace InternProjects.MouseActions
{
    [TestClass]
    public class DropDown
    {
        [TestMethod]
        public void TA_DropDown()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://testautomationpractice.blogspot.com/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[4]/div[2]/div[2]/div[2]/div[2]/div[2]/div[2]")));

            //Scroll to
            var element = driver.FindElement(By.XPath("//*[@id=\"animals\"]"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();


            Thread.Sleep(2000);
            IWebElement Select1 = driver.FindElement(By.XPath("//*[@id=\"speed\"]"));
            SelectElement selector1 = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"speed\"]")));
            selector1.SelectByText("Fast");

            Thread.Sleep(2000);
            IWebElement Select2 = driver.FindElement(By.XPath("//*[@id=\"files\"]"));
            SelectElement selector2 = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"files\"]")));
            selector2.SelectByText("PDF file");

            Thread.Sleep(2000);
            IWebElement Select3 = driver.FindElement(By.XPath("//*[@id=\"number\"]"));
            SelectElement selector3 = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"number\"]")));
            selector3.SelectByText("3");

            Thread.Sleep(2000);
            IWebElement Select4 = driver.FindElement(By.XPath("//*[@id=\"products\"]"));
            SelectElement selector4 = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"products\"]")));
            selector4.SelectByText("Iphone");

            Thread.Sleep(2000);
            IWebElement Select5 = driver.FindElement(By.XPath("//*[@id=\"animals\"]"));
            SelectElement selector5 = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"animals\"]")));
            selector5.SelectByText("Big Baby Cat");


            Thread.Sleep(5000);
            driver.Dispose();
        }
    }
}
