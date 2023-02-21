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
using System.Windows.Forms;

namespace DPSHTRR.Forms
{
    [TestClass]
    public class TargaProve
    {
        [TestMethod]
        public void TA_TargaProve()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://www.dpshtrr.al/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"edit-search-block-form--2\"]")));

            //Metoda e re
            IWebElement hoverable1 = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[1]"));
            new Actions(driver)
                .MoveToElement(hoverable1)
                .Perform();

            IWebElement hoverable2 = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[1]/ul/li[4]/a"));
            new Actions(driver)
                .MoveToElement(hoverable2)
                .Perform();

            
            //Targe prove click
            Thread.Sleep(1000);
            IWebElement hoverable3 = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[1]/ul/li[4]/ul/li[1]/a"));
            hoverable3.Click();





            ////Floating menu 1 Mjete
            //var Mjete = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[1]"));
            //    Actions actions = new Actions(driver);
            //    actions.MoveToElement(Mjete);
            //    actions.Perform();

            //    Thread.Sleep(1000);
            ////Floating menu 1 Targa
            //var Targa = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[1]/ul/li[4]/a"));
            //    Actions actions1 = new Actions(driver);
            //    actions1.MoveToElement(Targa);
            //    actions1.Perform();

            //    Thread.Sleep(1000);

            //    WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            //    wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[1]/ul/li[4]/ul")));

            ////Floating menu 1 Targa prove
            //var TargaProve = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[1]/ul/li[4]/ul/li[1]/a"));
            //    Actions actions2 = new Actions(driver);
            //    actions2.MoveToElement(TargaProve);
            //    actions2.Click();
            //    actions2.Perform();
                

            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"node-4666\"]/div/div[1]/div/div/p[2]")));



            //Presim sapo te lokalizojme venodhjen e fushes ku eshte butoni
            WebDriverWait wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait3.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[3]/section[3]/div/div/div/div[2]/div[2]/div/div/div[1]/div/div/p[2]/a")));



            //Scroll to view
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver; js.ExecuteScript("window.scrollBy(0,250)");
 
            //var element = driver.FindElement(By.XPath("//*[@id=\"node-4666\"]/div/div[1]/div/div/p[5]/strong"));
            //Actions actions4 = new Actions(driver);
            //actions4.MoveToElement(element).Perform();

             //Kliko butonin apliko
             IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("document.querySelector(\"#node-4666 > div > div.field.field-name-body.field-type-text-with-summary.field-label-hidden > div > div > p:nth-child(4) > a\").click()");

            WebDriverWait wait4 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait4.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"node-2377\"]")));



            //Radio button 1-Aplikim i ri
            IJavaScriptExecutor executor2 = (IJavaScriptExecutor)driver;
            executor2.ExecuteScript("document.querySelector(\"#edit-submitted-aplikimi > div:nth-child(2) > label\").click()");


            //IF/ELSE-Radio button

            bool  element = driver.FindElement(By.XPath("//*[@id=\"webform-client-form-2377\"]/div/div[2]/label")).Enabled;       
          
            // If radio button -Aplikimi i ri is selected , select radio button -Arsyeja e aplikimit
            if (element == true)
       
            {                
                IJavaScriptExecutor executor3 = (IJavaScriptExecutor)driver;
                executor3.ExecuteScript("document.querySelector(\"#edit-submitted-arsyeja-aplikim > div:nth-child(1) > label\").click()");
                Thread.Sleep(3000);
                
            }
            else
            {

                driver.Dispose();
            }


            //Formulari 
            //Emri Mbiemri
            IJavaScriptExecutor executor4 = (IJavaScriptExecutor)driver;
            executor4.ExecuteScript("document.querySelector(\"#edit-submitted-emri-i-subjektit-i-domosdoshem-subjekt-i-autorizuar-nga-prodhuesi-me-license-vii3b2-koncensionare\").value='Kristaina Carciu';");

            //Nipti
            IJavaScriptExecutor executor5 = (IJavaScriptExecutor)driver;
            executor5.ExecuteScript("document.querySelector(\"#edit-submitted-numri-i-nipt-it-i-domosdoshem\").value='xxxxxx';");

            //Adresa
            IJavaScriptExecutor executor6 = (IJavaScriptExecutor)driver;
            executor6.ExecuteScript("document.querySelector(\"#edit-submitted-adresa-e-subjektit-i-domosdoshem\").value='Rruga e Dibres';");


            //Administrator
            IJavaScriptExecutor executor7 = (IJavaScriptExecutor)driver;
            executor7.ExecuteScript("document.querySelector(\"#edit-submitted-administratori-emer-mbiemer-i-domosdoshem\").value='John Doe';");


            //NID
            IJavaScriptExecutor executor8 = (IJavaScriptExecutor)driver;
            executor8.ExecuteScript("document.querySelector(\"#edit-submitted-nid-i-domosdoshem\").value='K15903030P';");


            //Tel
            IJavaScriptExecutor executor9 = (IJavaScriptExecutor)driver;
            executor9.ExecuteScript("document.querySelector(\"#edit-submitted-numri-i-telefonit-celular-i-domosdoshem\").value='0677777777';");


            //Email
            IJavaScriptExecutor executor10 = (IJavaScriptExecutor)driver;
            executor10.ExecuteScript("document.querySelector(\"#edit-submitted-email-i-i-domosdoshem\").value='kricarciu@gmail.com';");


            //Nr targa
            IJavaScriptExecutor executor11 = (IJavaScriptExecutor)driver;
            executor11.ExecuteScript("document.querySelector(\"#edit-submitted-numri-sasia-e-targave-1-deri-5-i-domosdoshem\").value='1';");



            Thread.Sleep(2000);

            //Kliko Radio button-Kategoria
            IJavaScriptExecutor executor12 = (IJavaScriptExecutor)driver;
            executor12.ExecuteScript("document.querySelector(\"#edit-submitted-police-sigurimi-tpl-kujdes-targa-e-proves-duhet-te-perdoret-vetem-me-mjetet-qe-perfshin-kategoria-tpl-qe-perzgjidhni > div:nth-child(1) > label\").click()");
            
            //If Kategoria Radio button is selected, select security checkbox
           
            bool element1 = driver.FindElement(By.Id("edit-submitted-police-sigurimi-tpl-kujdes-targa-e-proves-duhet-te-perdoret-vetem-me-mjetet-qe-perfshin-kategoria-tpl-qe-perzgjidhni-1")).Enabled;
            if (element1 == true)
            {
                //Checkbox
                IJavaScriptExecutor executor13 = (IJavaScriptExecutor)driver;
                executor13.ExecuteScript("document.querySelector(\"#edit-submitted-pranoj-kushtet-i-domosdoshem-lexo-dispozitat-e-pergjithshme-1\").click()");
                Thread.Sleep(2000);
            }

            else
            {
                //Kategoria 2 radio button
                IJavaScriptExecutor executor13 = (IJavaScriptExecutor)driver;
                executor13.ExecuteScript("document.querySelector(\"#edit-submitted-police-sigurimi-tpl-kujdes-targa-e-proves-duhet-te-perdoret-vetem-me-mjetet-qe-perfshin-kategoria-tpl-qe-perzgjidhni > div:nth-child(2) > label\").click()");
                Thread.Sleep(2000);
                //driver.Dispose();
            }


            Thread.Sleep(4000);
            driver.Dispose();

        }
    }
}