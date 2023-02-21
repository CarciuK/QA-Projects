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

namespace InternProjects
{
    [TestClass]
    public class Slider
    {
        [TestMethod]
        public void TA_Slider()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://testautomationpractice.blogspot.com/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[4]/div[2]/div[2]/div[2]/div[2]/div[2]/div[2]")));

            var element = driver.FindElement(By.XPath("//*[@id=\"slider\"]"));
            Actions actions1 = new Actions(driver);
            actions1.MoveToElement(element);
            actions1.Perform();

            int x = 1/2;
            IWebElement slider = driver.FindElement(By.XPath("//*[@id=\"slider\"]"));
            int width = slider.Size.Width;
            Actions act = new Actions(driver);
            act.MoveToElement(slider, ((width * x)), 0).Click();
            act.Build().Perform();
            


            

            //Functional code,not performing action

            //IWebElement SliderBar = driver.FindElement(By.XPath("//*[@id=\"slider\"]"));
            //int WidthSliderBar = SliderBar.Size.Width;

            //IWebElement Slider1 = driver.FindElement(By.XPath("//*[@id=\"slider\"]/span"));
            //Actions Slideraction = new Actions(driver);
            //Slideraction.ClickAndHold(Slider1);
            //Actions Slider = Slideraction.MoveByOffset(50,0);
            //Slider.Release().Build();


            Thread.Sleep(5000);
            driver.Dispose();
        }
    }
}
