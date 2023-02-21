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
    public class DragDrop
    {
        [TestMethod]
        public void TA_DragDrop()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://testautomationpractice.blogspot.com/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[4]/div[2]/div[2]/div[2]/div[2]/div[2]/div[2]")));

            //scroll to
            var element = driver.FindElement(By.XPath("//*[@id=\"HTML2\"]/h2"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();


            Actions Drag = new Actions(driver);
            IWebElement from = driver.FindElement(By.XPath("//*[@id=\"draggable\"]"));
            IWebElement to = driver.FindElement(By.XPath("//*[@id=\"droppable\"]"));
            //Perform drag and drop
            Drag.DragAndDrop(from, to).Perform();

            //Secong drag and drop action

            Thread.Sleep(5000);
            //scroll to
            var element1 = driver.FindElement(By.XPath("//*[@id=\"animals\"]"));
            Actions actions1 = new Actions(driver);
            actions.MoveToElement(element1);
            actions.Perform();

            //Drag 1,2
            Actions Drag1 = new Actions(driver);
            IWebElement from1 = driver.FindElement(By.XPath("//*[@id=\"gallery\"]/li[1]/img"));
            IWebElement to1 = driver.FindElement(By.XPath("//*[@id=\"trash\"]"));
            //Perform drag and drop
            Drag1.DragAndDrop(from1, to1).Perform();


            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"trash\"]/ul/li/img")));


            Actions Drag2 = new Actions(driver);
            IWebElement from2 = driver.FindElement(By.XPath("//*[@id=\"gallery\"]/li/img"));
            IWebElement to2 = driver.FindElement(By.XPath("//*[@id=\"trash\"]"));
            //Perform drag and drop
            Drag2.DragAndDrop(from2, to2).Perform();


            Thread.Sleep(4000);
            driver.Dispose();
        }
    }
}
