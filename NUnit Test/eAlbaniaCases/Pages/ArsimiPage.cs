using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Test.eAlbaniaCases.Pages
{
    public class ArsimiPage : BaseDriverPage
    {

     public IWebElement PerdorBTN => driver.FindElement(By.XPath("//*[@id=\"BodyContent_UseService\"]"));
        //Regjistrime
     public IWebElement TeTjera => driver.FindElement(By.XPath("//*[@id=\"ctl01\"]/div[3]/div[2]/div[2]/div/img"));
     public IWebElement  RegjistrimeMenu => driver.FindElement(By.XPath("//*[@id=\"3:15-5025\"]/div/div/h5"));
     public IWebElement  Transferim => driver.FindElement(By.XPath("//*[@id=\"container-services\"]/div[19]/div/div[1]/div[1]"));

   


        public void Prove()             
     {
            TeTjera.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
          
            RegjistrimeMenu.Click();
            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

            Transferim.Click();
            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            PerdorBTN.Click();

            IJavaScriptExecutor executor2 = (IJavaScriptExecutor)driver;
            executor2.ExecuteScript("document.querySelector(\"#eform\").click()");

        }



      













    }
}
