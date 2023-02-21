using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Test.DemoSite.PagesDemoSite
{
    public class LogInPage : BaseDriverPage
    {

        IWebElement txtUserName => driver.FindElement(By.Id("UserName"));
        IWebElement txtPassword => driver.FindElement(By.Id("Password"));
        IWebElement btnLogin => driver.FindElement(By.CssSelector(".btn-default"));


        public void EnterUserNameAndPassword(string userName, string password)
        {

            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);

        }

        public void ClickLogIn()
        {
            btnLogin.Click();

        }



    }
}
