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
    public class ItemToCart
    {
        [TestMethod]
        public void TA_ItemToCart()
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


            //Search

            IWebElement Searchbar = driver.FindElement(By.XPath("//*[@id=\"search_widget\"]/form/div[1]/input"));
            Searchbar.Click();
            Searchbar.SendKeys("Dune");

            IWebElement Searchbutton = driver.FindElement(By.XPath("//*[@id=\"search_widget\"]/form/div[1]/button/i"));
            Searchbutton.Click();

            WebDriverWait wait4 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait4.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"js-product-list\"]/div[1]/div[3]/article/div[1]/a/img")));


            IWebElement Item = driver.FindElement(By.XPath("//*[@id=\"js-product-list\"]/div[1]/div[2]/article/div[1]/a/img"));
            Item.Click();

            WebDriverWait wait5 = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            wait5.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"main-product-wrapper\"]/div[1]/div[2]")));
           

            //Add item to cart
            IWebElement AddCart = driver.FindElement(By.XPath("//*[@id=\"add-to-cart-or-refresh\"]/div[6]/div/div[2]/div/button"));
            AddCart.Click();
            

            //var wait6 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //wait6.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//*[@id=\"blockcart-notification\"]")));           
            Thread.Sleep(4000);
      

            IWebElement Cart = new WebDriverWait(driver, TimeSpan.FromSeconds(35))
            .Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"cart-toogle\"]/span/span[1]")));
            Cart.Click();

            //IWebElement Cart = driver.FindElement(By.XPath("//*[@id=\"cart-toogle\"]/span/span[1]"));
            //Cart.Click();

            WebDriverWait wait7 = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            wait7.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"_desktop_blockcart-content\"]")));

            Thread.Sleep(2000);
            IWebElement Cartbutton = driver.FindElement(By.XPath("//*[@id=\"blockcart-content\"]/div[3]/a[2]"));
            Cartbutton.Click();

            WebDriverWait wait8 = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            wait8.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"wrapper\"]")));


            //Assert.AreEqual("Shporta", driver.Title);
            Thread.Sleep(5000);
            driver.Dispose();

        }
    }
}
