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
    public class Resizable
    {
        [TestMethod]
        public void TA_Resizable()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://testautomationpractice.blogspot.com/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[4]/div[2]/div[2]/div[2]/div[2]/div[2]/div[2]")));

            //Scroll to
            var element = driver.FindElement(By.XPath("//*[@id=\"HTML1\"]/div[1]/table/tbody/tr[1]/th[4]"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();

            //PUNON 1

            //Kliko butonin ne resize field edhe ndrysho parametrat x dhe y
            var resize = driver.FindElement(By.XPath("//*[@id=\"resizable\"]/div[3]"));
            Actions actions1 = new Actions(driver);
            actions1.MoveToElement(resize);
            actions1.ClickAndHold(resize).DragAndDropToOffset(resize, 200, 150);
            actions1.Release();
            actions1.Build();
            actions1.Perform();



            //PUNON 2


            // var RightMove = driver.FindElement(By.XPath("//*[@id=\"resizable\"]/div[1]"));
            // var DownMove = driver.FindElement(By.XPath("//*[@id=\"resizable\"]/div[2]"));

            // //Leviz Djathtas
            // Actions actions1 = new Actions(driver);
            // actions1.MoveToElement(RightMove);
            // actions1.ClickAndHold(RightMove).DragAndDropToOffset(RightMove, 200, 0);
            // actions1.Release();
            // actions1.Build();
            // actions1.Perform();

            ////Leviz Poshte
            // Actions actions2 = new Actions(driver);
            // actions2.MoveToElement(DownMove);
            // actions2.ClickAndHold(DownMove).DragAndDropToOffset(DownMove, 0 , 200);
            // actions2.Release();
            // actions2.Build();
            // actions2.Perform();







            Thread.Sleep(4000);
            driver.Dispose();
        }
    }
}
