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

namespace FinalProjectIkub
{
    [TestClass]
    public class CreateAccount
    {
        [TestMethod]
        public void TA_CreateAccount()
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

            IWebElement Account = new WebDriverWait(driver, TimeSpan.FromSeconds(35))
          .Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"content\"]/div/a")));
            Account.Click();

            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"inner-wrapper\"]")));


            //

            IWebElement Mrs = driver.FindElement(By.XPath("//*[@id=\"customer-form\"]/section/div[1]/div[1]/label[2]/span/input"));
            Mrs.Click();

            IWebElement Name = driver.FindElement(By.XPath("//*[@id=\"customer-form\"]/section/div[2]/div[1]/input"));
            Name.Click();
            Name.SendKeys("Krista");

            IWebElement Lastname = driver.FindElement(By.XPath("//*[@id=\"customer-form\"]/section/div[3]/div[1]/input"));
            Lastname.Click();
            Lastname.SendKeys("Carciu");


            IWebElement Email = driver.FindElement(By.XPath("//*[@id=\"customer-form\"]/section/div[4]/div[1]/input"));
            Email.Click();
            Email.SendKeys("kristacharchiu07@gmail.com");
            //Change email
            //kristacharchiu04 @gmail.com
            
            IWebElement Password = driver.FindElement(By.XPath("//*[@id=\"customer-form\"]/section/div[5]/div[1]/div/input"));
            Password.Click();
            Password.SendKeys("kristacharchiu04@");

            IWebElement Birthdate = driver.FindElement(By.XPath("//*[@id=\"customer-form\"]/section/div[6]/div[1]/input"));
            Birthdate.Click();
            Birthdate.SendKeys("03/09/2001");

            IWebElement offers = driver.FindElement(By.XPath("//*[@id=\"ff_optin\"]"));
            offers.Click();

            IWebElement newsletter = driver.FindElement(By.XPath("//*[@id=\"ff_newsletter\"]"));
            newsletter.Click();



            IWebElement newsletteremail = driver.FindElement(By.XPath("//*[@id=\"footer-container-main\"]/div/div[2]/div[4]/div[2]/div/div/form/div[1]/input"));
            newsletteremail.Click();

            IWebElement Save = driver.FindElement(By.XPath("//*[@id=\"customer-form\"]/footer/button"));
            Save.Click();
            WebDriverWait wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait3.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"desktop-header\"]/div[1]")));


            Assert.AreEqual("ADRION Ltd - Libraria më e madhe në Shqipëri", driver.Title);

            //Thread.Sleep(7000);
            driver.Dispose();



        }
    }
}
