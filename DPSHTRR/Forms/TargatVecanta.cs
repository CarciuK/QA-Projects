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
using NUnit.Framework.Internal;
using OpenQA.Selenium.DevTools;

namespace DPSHTRR.Forms
{
    [TestClass]
    public class TargatVecanta
    {
     

        [TestMethod]
        public void TA_TargatVecanta()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://www.dpshtrr.al/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"edit-search-block-form--2\"]")));



            //Floating menu 1 Mjete
            var Mjete = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[1]"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(Mjete);
            actions.Perform();

            Thread.Sleep(1000);
            //Floating menu 1 Targa
            var Targa = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[1]/ul/li[4]/a"));
            Actions actions1 = new Actions(driver);
            actions1.MoveToElement(Targa);
            actions1.Perform();

            Thread.Sleep(1000);

            //Floating menu 1 Targa prove
            var TargaVecanta = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[1]/ul/li[4]/ul/li[2]/a"));
            Actions actions2 = new Actions(driver);
            actions2.MoveToElement(TargaVecanta);
            actions2.Click();
            actions2.Perform();


            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"node-4668\"]/div/div/div/div")));


            //Scroll to view
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver; js.ExecuteScript("window.scrollBy(0,350)");

            //Kliko butonin apliko
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("document.querySelector(\"#node-4668 > div > div > div > div > p:nth-child(6) > a\").click()");


            WebDriverWait wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait3.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"cdk-step-content-0-0\"]/div/div/div[1]")));

            Thread.Sleep(2000);
            
            //Kliko kerko targe
            IJavaScriptExecutor executor1 = (IJavaScriptExecutor)driver;
            executor1.ExecuteScript("document.querySelector(\"#cdk-step-content-0-0 > div > div > div.actions > button > span\").click()");
            
            
            WebDriverWait wait4 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait4.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-booking-form/div[1]/mat-vertical-stepper/div[2]")));


            //Ploteso lloji i mjetit
            Thread.Sleep(1000);
            var element = driver.FindElement(By.XPath("//*[@id=\"mat-select-0\"]/div/div[1]/span"));
            IJavaScriptExecutor  executor2  = (IJavaScriptExecutor) driver;
            executor2.ExecuteScript("arguments[0].click();", element);
            executor2.ExecuteScript("document.querySelector(\"#mat-option-0 > span\").click()");

            Thread.Sleep(2000);

            var element1 = driver.FindElement(By.XPath("//*[@id=\"mat-select-1\"]"));
            IJavaScriptExecutor executor3 = (IJavaScriptExecutor)driver;
            executor3.ExecuteScript("arguments[0].click();", element1);
            executor3.ExecuteScript("document.querySelector(\"#mat-option-2 > span\").click()");
            

            //Targa Vazhdo button
            IJavaScriptExecutor executor4 = (IJavaScriptExecutor)driver;
            executor4.ExecuteScript("document.querySelector(\"#cdk-step-content-0-1 > div > form > div > button.mat-raised-button.mat-accent > span\").click()");

            WebDriverWait wait5 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait5.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"cdk-step-content-0-2\"]/div")));

            //Kerko targ       
            var targa = driver.FindElement(By.XPath("/html/body/app-root/app-booking-form/div[1]/mat-vertical-stepper/div[3]/div/div/div/form/mat-form-field/div/div[1]/div/input"));
            targa.SendKeys("010");

            Thread.Sleep(5000);

            //Kliko checkbox
            var checkbox = driver.FindElement(By.XPath("/html/body/app-root/app-booking-form/div[1]/mat-vertical-stepper/div[3]/div/div/div/form/div[1]/mat-table/mat-row[1]/mat-cell[1]/mat-checkbox/label/div"));
            checkbox.Click();

            Thread.Sleep(3000);    
             
            //Kliko Butonin REZERVO
            var RezervoBTN = driver.FindElement(By.XPath("/html/body/app-root/app-booking-form/div[1]/mat-vertical-stepper/div[3]/div/div/div/form/div[2]/button[2]"));
            RezervoBTN.Click();

            WebDriverWait wait6 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait6.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"cdk-step-content-0-3\"]")));


            //Select "Per biznes" checkbox
           
            IWebElement CheckBox = driver.FindElement(By.XPath("//*[@id=\"mat-checkbox-6\"]/label"));
            CheckBox.Click();
            Thread.Sleep(2000);

            //If /else
                bool Checkbox1 = driver.FindElement(By.XPath("//*[@id=\"mat-checkbox-6-input\"]")).Selected;
            if (Checkbox1 == true)
            {
                //Emri
                Thread.Sleep(1000);
                WebDriverWait wait7 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                wait7.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"cdk-step-content-0-3\"]/div/form/mat-form-field[1]/div/div[1]")));

                IJavaScriptExecutor executor6 = (IJavaScriptExecutor)driver;
                executor6.ExecuteScript("document.querySelector(\"#mat-input-1\").click()");
                executor6.ExecuteScript("document.querySelector(\"#mat-input-1\").value='Kristina';");


                //Mbiemri
                Thread.Sleep(1000);
                IJavaScriptExecutor executor7 = (IJavaScriptExecutor)driver;
                executor7.ExecuteScript("document.querySelector(\"#mat-input-2\").click()");
                executor7.ExecuteScript("document.querySelector(\"#mat-input-2\").value='Carciu';");

                //Atesia
                Thread.Sleep(1000);
                IJavaScriptExecutor executor8 = (IJavaScriptExecutor)driver;
                executor8.ExecuteScript("document.querySelector(\"#mat-input-3\").click()");
                executor8.ExecuteScript("document.querySelector(\"#mat-input-3\").value='Dritan';");



                //Datelindja
                Thread.Sleep(1000);
                IJavaScriptExecutor executor9 = (IJavaScriptExecutor)driver;
                executor9.ExecuteScript("document.querySelector(\"#mat-input-4\").click()");
                executor9.ExecuteScript("document.querySelector(\"#mat-input-4\").value='11/22/2222';");



                //NID
                Thread.Sleep(1000);
                IJavaScriptExecutor executor10 = (IJavaScriptExecutor)driver;
                executor10.ExecuteScript("document.querySelector(\"#mat-input-5\").click()");
                executor10.ExecuteScript("document.querySelector(\"#mat-input-5\").value='K15909090P';");

                //NIPT
                Thread.Sleep(1000);
                IJavaScriptExecutor executor11 = (IJavaScriptExecutor)driver;
                executor11.ExecuteScript("document.querySelector(\"#mat-input-6\").click()");
                executor11.ExecuteScript("document.querySelector(\"#mat-input-6\").value='xxxxxx';");


                //Gjinia
                Thread.Sleep(1000);
                var element3 = driver.FindElement(By.XPath("/html/body/app-root/app-booking-form/div[1]/mat-vertical-stepper/div[4]/div/div/div/form/mat-form-field[7]/div/div[1]/div/mat-select/div"));
                IJavaScriptExecutor executor12 = (IJavaScriptExecutor)driver;
                executor12.ExecuteScript("arguments[0].click();", element3);
                executor12.ExecuteScript("document.querySelector(\"#mat-option-23\").click()");
                Thread.Sleep(2000);


                //Shasia
                Thread.Sleep(1000);
                IJavaScriptExecutor executor13 = (IJavaScriptExecutor)driver;
                executor13.ExecuteScript("document.querySelector(\"#mat-input-7\").click()");
                executor13.ExecuteScript("document.querySelector(\"#mat-input-7\").value='xxxxxx';");


                //Email
                Thread.Sleep(1000);
                IJavaScriptExecutor executor14 = (IJavaScriptExecutor)driver;
                executor14.ExecuteScript("document.querySelector(\"#mat-input-8\").click()");
                executor14.ExecuteScript("document.querySelector(\"#mat-input-8\").value='email@gmail.com';");


                //Email
                Thread.Sleep(1000);
                IJavaScriptExecutor executor15 = (IJavaScriptExecutor)driver;
                executor15.ExecuteScript("document.querySelector(\"#mat-input-9\").click()");
                executor15.ExecuteScript("document.querySelector(\"#mat-input-9\").value='0677777777';");


            }


            else
            {
                driver.Dispose();

            }


            Thread.Sleep(4000);
            driver.Dispose();


        }
    }
}