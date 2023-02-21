//using NUnit_Test.eAlbaniaCases.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Test.Cases.Pages
{
    public class LogInPage : BaseDriverPage
    {
        public IWebElement LogIn => driver.FindElement(By.XPath("//*[@id=\"navbarCollapse\"]/div/div[3]/div[4]/ul[1]/li[1]/a"));
        public IWebElement Qytetar => driver.FindElement(By.XPath(" //*[@id=\"MainContent_pnlIdentityProviders\"]/div/table/tbody/tr[1]/td[1]/a/img"));
        public IWebElement NIDLogIn => driver.FindElement(By.Id("MainContent_txtUserName"));
        public IWebElement Password => driver.FindElement(By.Id("MainContent_txtPassword"));
        public IWebElement LogBTN => driver.FindElement(By.Id("MainContent_btnSubmit"));

        public void UserLogIn()
        {
            LogIn.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"MainContent_pnlIdentityProviders\"]/div/table")));

            Qytetar.Click();
           
            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"stsform\"]/div[3]/div/div/div/div/div")));
            
            NIDLogIn.SendKeys("K15903030P");

            Password.SendKeys("KristinaCarciu3");

            LogBTN.Click();


            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("ctl01")));

        }

    }

    
}
