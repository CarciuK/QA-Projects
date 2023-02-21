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

namespace FinalProjectIkub
{
    [TestClass]
    public class LogInP
    {
        [TestMethod]
        public void TA_LogInP()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://www.adrionltd.com/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"desktop-header\"]/div[1]")));

            IWebElement cookies = driver.FindElement(By.XPath("//*[@id=\"iqitcookielaw-accept\"]"));
            cookies.Click();


            IWebElement Signin = driver.FindElement(By.XPath("//*[@id=\"header-user-btn\"]/a"));
            Signin.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"submit-login\"]")));


            IWebElement Email = driver.FindElement(By.XPath("//*[@id=\"login-form\"]/section/div[1]/div[1]/input"));
            Email.Click();
            Email.SendKeys("kristacharchiu04@gmail.com");

            IWebElement Password = driver.FindElement(By.XPath("//*[@id=\"login-form\"]/section/div[2]/div[1]/div/input"));
            Password.Click();
            Password.SendKeys("kristacharchiu04@");

            IWebElement newsletteremail = driver.FindElement(By.XPath("//*[@id=\"footer-container-main\"]/div/div[2]/div[4]/div[2]/div/div/form/div[1]/input"));
            newsletteremail.Click();

            IWebElement Signinbutton = driver.FindElement(By.XPath("//*[@id=\"submit-login\"]"));
            Signinbutton.Click();

            WebDriverWait wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait3.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"desktop-header\"]/div[1]")));

            Assert.AreEqual("Llogaria ime", driver.Title);

            //String expectedtitle = "Adrion LT";
            //String actualtitle = driver.FindElement(By.XPath("//*[@id=\"desktop_logo\"]/a/img")).Text.ToString();
            //Assert.AreEqual(expectedtitle, actualtitle);


            Thread.Sleep(4000);
            driver.Dispose();



        }
    }
}
