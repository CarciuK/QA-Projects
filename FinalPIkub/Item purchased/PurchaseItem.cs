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

namespace FinalProjectIkub
{
    [TestClass]
    public class PurchaseItem
    {
        [TestMethod]
        public void TA_PurchaseItem()
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

            IWebElement Cart = new WebDriverWait(driver, TimeSpan.FromSeconds(45))
            .Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"cart-toogle\"]/span/span[1]")));
            Cart.Click();

            //IWebElement Cart = driver.FindElement(By.XPath("//*[@id=\"cart-toogle\"]/span/span[1]"));
            //Cart.Click();
            WebDriverWait wait7 = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            wait7.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"_desktop_blockcart-content\"]")));

            IWebElement Cartbutton = driver.FindElement(By.XPath("//*[@id=\"blockcart-content\"]/div[3]/a[2]"));
            Cartbutton.Click();

            WebDriverWait wait8 = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            wait8.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"main\"]/div/div[1]/div/div/ul/li[2]/div")));
            ///

            IWebElement ProceedCheckout = driver.FindElement(By.XPath("//*[@id=\"main\"]/div/div[2]/div/div[2]/div/a"));
            ProceedCheckout.Click();

            WebDriverWait wait9 = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            wait9.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"main\"]/div/div[1]")));

            //Checkoutaddress

            IWebElement Firstname = driver.FindElement(By.XPath("//*[@id=\"delivery-address\"]/div/section/div[1]/div[1]/input"));
            Firstname.Click();
            IWebElement Lastname = driver.FindElement(By.XPath("//*[@id=\"delivery-address\"]/div/section/div[2]/div[1]/input"));
            Lastname.Click();

            IWebElement Company = driver.FindElement(By.XPath("//*[@id=\"delivery-address\"]/div/section/div[3]/div[1]/input"));
            Company.Click();
            Company.SendKeys("IkubInfo");

            IWebElement VAT = driver.FindElement(By.XPath("//*[@id=\"delivery-address\"]/div/section/div[4]/div[1]/input"));
            VAT.Click();

            IWebElement Address = driver.FindElement(By.XPath("//*[@id=\"delivery-address\"]/div/section/div[5]/div[1]/input"));
            Address.Click();
            Address.SendKeys("Rruga e Dibres");

            IWebElement Address2 = driver.FindElement(By.XPath("//*[@id=\"delivery-address\"]/div/section/div[6]/div[1]/input"));
            Address2.Click();

            IWebElement ZIP = driver.FindElement(By.XPath("//*[@id=\"delivery-address\"]/div/section/div[7]/div[1]/input"));
            ZIP.Click();
            ZIP.SendKeys("1001");

            IWebElement Qyteti = driver.FindElement(By.XPath("//*[@id=\"delivery-address\"]/div/section/div[8]/div[1]/input"));
            Qyteti.Click();
            Qyteti.SendKeys("Tirane");

            IWebElement Shteti = driver.FindElement(By.XPath("//*[@id=\"delivery-address\"]/div/section/div[9]/div[1]/div/select"));
            SelectElement selector1 = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"delivery-address\"]/div/section/div[9]/div[1]/div/select")));
            selector1.SelectByValue("230");

            IWebElement Rrethi = driver.FindElement(By.XPath("//*[@id=\"delivery-address\"]/div/section/div[10]/div[1]/div/select"));
            SelectElement selector2 = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"delivery-address\"]/div/section/div[10]/div[1]/div/select")));
            selector2.SelectByValue("379");

            IWebElement Phone = driver.FindElement(By.XPath("//*[@id=\"delivery-address\"]/div/section/div[11]/div[1]/input"));
            Phone.Click();
            Phone.SendKeys("0677777777");

            IWebElement SubmitAddress = driver.FindElement(By.XPath("//*[@id=\"delivery-address\"]/div/footer/button"));
            SubmitAddress.Click();

            WebDriverWait wait10 = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            wait10.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"checkout-delivery-step\"]")));

            IWebElement ContinueToPayment = driver.FindElement(By.XPath("//*[@id=\"js-delivery\"]/button"));
            ContinueToPayment.Click();

            WebDriverWait wait11 = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            wait11.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"checkout-payment-step\"]/div")));

            IWebElement ClickVisa = driver.FindElement(By.XPath("//*[@id=\"payment-option-2\"]"));
            ClickVisa.Click();
            IWebElement TermsConditions = driver.FindElement(By.XPath("//*[@id=\"conditions_to_approve[terms-and-conditions]\"]"));
            TermsConditions.Click();


            //Submit-Payment

            Thread.Sleep(5000);
            //Assert.AreEqual("Porosi personale", driver.Title);
            driver.Dispose();

        }
    }
}
