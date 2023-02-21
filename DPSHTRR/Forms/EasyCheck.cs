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

namespace DPSHTRR.Forms
{
    [TestClass]
    public class EasyCheck
    {
        [TestMethod]
        public void TA_EasyCheck()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://www.dpshtrr.al/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"edit-search-block-form--2\"]")));


            //Floating menu 4 Sherbim online

            IWebElement hoverable1 = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[4]/a"));
            new Actions(driver)
                .MoveToElement(hoverable1)
                .Perform();


            //Easy check menu
            IWebElement hoverable2 = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[4]/ul/li[5]/a"));
            new Actions(driver)
                .MoveToElement(hoverable2)
                .Perform();


            //Easy check fizik
            Thread.Sleep(1000);
            IWebElement hoverable3 = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[4]/ul/li[5]/ul/li[1]/a"));
            hoverable3.Click();


            //Menyra hover e vjeter

            //var Sherbim = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[4]/a"));
            //Actions actions3 = new Actions(driver);
            //actions3.MoveToElement(Sherbim);
            //actions3.Perform();

            //Thread.Sleep(1000);
            ////Perzgjedhim opt Easy Check
            //var Check = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[4]/ul/li[5]/a"));
            //Actions actions4 = new Actions(driver);
            //actions4.MoveToElement(Check);
            //actions4.Perform();


            //Thread.Sleep(1000);
            ////Perzgjedhim opt Easy Check Kontroll fizik
            //var CheckFizik = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[4]/ul/li[5]/ul/li[1]/a"));
            //Actions actions5 = new Actions(driver);
            //actions5.MoveToElement(CheckFizik).Click();
            //actions5.Perform();


            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"node-2838\"]")));

            //Scroll to view
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver; js.ExecuteScript("window.scrollBy(0,750)");

            //Tirane radio button
            IJavaScriptExecutor executor1 = (IJavaScriptExecutor)driver;
            executor1.ExecuteScript("document.querySelector(\"#edit-submitted-drejtoria-rajonale-ku-merrni-sherbim > div:nth-child(1) > label\").click()");

            //Emri mbiemer
            IJavaScriptExecutor executor2 = (IJavaScriptExecutor)driver;
            executor2.ExecuteScript("document.querySelector(\"#edit-submitted-te-dhena-per-kontakt-emer-mbiemer\").value='Krista Carciu';");


            //Emri
            IJavaScriptExecutor executor3 = (IJavaScriptExecutor)driver;
            executor3.ExecuteScript("document.querySelector(\"#edit-submitted-te-dhena-per-kontakt-emer-mbiemer\").value='Krista';");

            //Tel
            IJavaScriptExecutor executor4 = (IJavaScriptExecutor)driver;
            executor4.ExecuteScript("document.querySelector(\"#edit-submitted-te-dhena-per-kontakt-telefon\").value='067777777';");


            //Email
            IJavaScriptExecutor executor5 = (IJavaScriptExecutor)driver;
            executor5.ExecuteScript("document.querySelector(\"#edit-submitted-te-dhena-per-kontakt-e-mail\").value='kristacarc@gmail.com';");

            //Emri subjekti
            IJavaScriptExecutor executor6 = (IJavaScriptExecutor)driver;
            executor6.ExecuteScript("document.querySelector(\"#edit-submitted-te-dhena-per-kontakt-emri-i-subjektit\").value='Emri';");

            //nipt
            IJavaScriptExecutor executor7 = (IJavaScriptExecutor)driver;
            executor7.ExecuteScript("document.querySelector(\"#edit-submitted-te-dhena-per-kontakt-nipt\").value='xxxx';");


            //adresa
            IJavaScriptExecutor executor8 = (IJavaScriptExecutor)driver;
            executor8.ExecuteScript("document.querySelector(\"#edit-submitted-te-dhena-per-kontakt-adresa-e-sakte\").value='rr e dibres';");


            //Form no 2
            IJavaScriptExecutor executor9 = (IJavaScriptExecutor)driver;
            executor9.ExecuteScript("document.querySelector(\"#edit-submitted-te-dhena-per-mjetet-mjeti-1-shasia\").value='Info per mjetin';");


            //Scroll to checkbox
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver; js.ExecuteScript("window.scrollBy(0,1780)");
            Thread.Sleep(3000);


            //Kliko Checkbox-in e autorizimit
            IJavaScriptExecutor executor10 = (IJavaScriptExecutor)driver;
            executor10.ExecuteScript("document.querySelector(\"#edit-submitted-autorizoj-1\").click()");

            Boolean element = driver.FindElement(By.Id("edit-submitted-autorizoj-1")).Selected;
            if (element == true)
            {
                IJavaScriptExecutor executor11 = (IJavaScriptExecutor)driver;
                executor11.ExecuteScript(" document.querySelector(\"#edit-submitted-te-dhena-per-mjetet-dispononi-me-shume-se-5-mjete-listoni-shasite-per-cdo-mjet\").value='Punoi';");

            }

            else 
            {
                driver.Dispose();
            }

          

            Thread.Sleep(6000);
            driver.Dispose();
        }
    }
}