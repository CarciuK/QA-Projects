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
    public class ChangeInfo
    {
        [TestMethod]
        public void TA_ChangeInfo()
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
            wait3.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"main\"]")));

            IWebElement Information = driver.FindElement(By.XPath("//*[@id=\"identity-link\"]"));
            Information.Click();

            WebDriverWait wait4 = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
            wait4.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"content\"]/div/div[2]")));

            IWebElement Passwordold = driver.FindElement(By.XPath("//*[@id=\"customer-form\"]/section/div[5]/div[1]/div/input"));
            Passwordold.Click();
            Passwordold.SendKeys("kristacharchiu04@");

            IWebElement Passwordnew = driver.FindElement(By.XPath("//*[@id=\"customer-form\"]/section/div[6]/div[1]/div/input"));
            Passwordnew.Click();
            Passwordnew.SendKeys("kristacharchiu04");


            IWebElement UnCheck1 = driver.FindElement(By.XPath("//*[@id=\"ff_optin\"]"));
            UnCheck1.Click();
            IWebElement UnCheck2 = driver.FindElement(By.XPath("//*[@id=\"ff_newsletter\"]"));
            UnCheck2.Click();

            IWebElement newslettermail = driver.FindElement(By.XPath("//*[@id=\"footer-container-main\"]/div/div[2]/div[4]/div[2]/div/div/form/div[1]/input"));
            newslettermail.Click();

            IWebElement Save = driver.FindElement(By.XPath("//*[@id=\"customer-form\"]/footer/button"));
            Save.Click();

            WebDriverWait wait5 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait5.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"notifications\"]/article")));







            Thread.Sleep(5000);
            Assert.AreEqual("Identiteti", driver.Title);
            driver.Dispose();
        }
    }
}
