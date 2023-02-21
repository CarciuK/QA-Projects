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
using System.Windows.Forms;

namespace FinalProjectIkub
{
    [TestClass]
    public class UploadFile
    {
        [TestMethod]
        public void TA_UploadFile()
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

            //Upload

            IWebElement Account = driver.FindElement(By.XPath("//*[@id=\"header-user-btn\"]/a"));
            Account.Click();

            WebDriverWait wait4 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait4.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"footer-container-main\"]")));


            IWebElement Personalorder = driver.FindElement(By.XPath("//*[@id=\"footer-container-main\"]/div/div[2]/div[1]/div/ul/li[4]/a"));
            Personalorder.Click();
            WebDriverWait wait5 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait5.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"wpcfu-f1-o1\"]/form/div[1]")));


            IWebElement Emri = driver.FindElement(By.XPath("//*[@id=\"wpcfu-f1-o1\"]/form/div[1]/div[2]/div[1]/div/label/span[2]/input"));
            Emri.Click();
            IWebElement Mbiemri = driver.FindElement(By.XPath("//*[@id=\"wpcfu-f1-o1\"]/form/div[1]/div[2]/div[2]/div/label/span[2]/input"));
            Mbiemri.Click();
            IWebElement Email2 = driver.FindElement(By.XPath("//*[@id=\"wpcfu-f1-o1\"]/form/div[1]/div[3]/div[1]/div/label/span[2]/input"));
            Email2.Click();

            IWebElement Telphone = driver.FindElement(By.XPath("//*[@id=\"wpcfu-f1-o1\"]/form/div[1]/div[3]/div[2]/div/label/span[2]/input"));
            Telphone.Click();
            Telphone.SendKeys("0677777777");

            IWebElement Adressa = driver.FindElement(By.XPath("//*[@id=\"wpcfu-f1-o1\"]/form/div[1]/div[4]/div[1]/div/label/span[2]/textarea"));
            Adressa.Click();
            Adressa.SendKeys("Rruga e dibres");

            IWebElement Qyteti = driver.FindElement(By.XPath("//*[@id=\"wpcfu-f1-o1\"]/form/div[1]/div[4]/div[2]/div/label/span[2]/textarea"));
            Qyteti.Click();
            Adressa.SendKeys("Tirana");

            IWebElement Titulli = driver.FindElement(By.XPath("//*[@id=\"wpcfu-f1-o1\"]/form/div[1]/div[6]/div[1]/div/label/span[2]/textarea"));
            Titulli.Click();
            Titulli.SendKeys("Dune");

            IWebElement Autori = driver.FindElement(By.XPath("//*[@id=\"wpcfu-f1-o1\"]/form/div[1]/div[6]/div[2]/div/label/span[2]/textarea"));
            Autori.Click();
            Autori.SendKeys("Frank Herbert");

            IWebElement ISBN = driver.FindElement(By.XPath("//*[@id=\"wpcfu-f1-o1\"]/form/div[1]/div[7]/div[1]/div/label/span[2]/textarea"));
            ISBN.Click();
            ISBN.SendKeys("9781101948804");

            //Upload 
            string path = @"C:\Users\carci\Desktop\Scanned Documents.pdf";
            driver.FindElement(By.XPath("//*[@id=\"wpcfu-f1-o1\"]/form/div[1]/div[8]/div/div[1]/label/span[2]/span[1]/input")).SendKeys(path);



            Thread.Sleep(5000);
            SendKeys.SendWait(path);
            SendKeys.SendWait(@"{Enter}");

            IWebElement Notes = driver.FindElement(By.XPath("//*[@id=\"wpcfu-f1-o1\"]/form/div[1]/div[8]/div/div[2]/label/span[2]/textarea"));
            Notes.Click();
            Notes.SendKeys("Scaned Document uploaded");
            

            Assert.AreEqual("Porosi personale", driver.Title);
            Thread.Sleep(5000);
            driver.Dispose();



        }
    }
}
