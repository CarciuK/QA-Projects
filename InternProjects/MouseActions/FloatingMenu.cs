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

namespace InternProjects.MouseActions
{

    [TestClass]
    public class FloatingMenu
    {
        [TestMethod]
        public void TA_FloatingMenu()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body")));

            IWebElement FloatMenu = driver.FindElement(By.XPath("//*[@id=\"content\"]/ul/li[19]/a"));
            FloatMenu.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"content\"]/div/div[2]/div")));


            var element = driver.FindElement(By.XPath("//*[@id=\"content\"]/div/div[2]/div/p[2]"));
            Actions actions1 = new Actions(driver);
            actions1.MoveToElement(element);
            actions1.Perform();

            Thread.Sleep(3000);

            IWebElement news = driver.FindElement(By.XPath("//*[@id=\"menu\"]/ul/li[2]/a"));
            Actions action = new Actions(driver);
            action.MoveToElement(news).Perform();


            Thread.Sleep(4000);
            driver.Dispose();

        }
    }
}