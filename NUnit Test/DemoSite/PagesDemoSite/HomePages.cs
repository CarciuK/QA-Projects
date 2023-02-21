using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Test.DemoSite.PagesDemoSite
{
    public class HomePages : BaseDriverPage
    {

      public IWebElement lnkLogIn => driver.FindElement(By.LinkText("Login"));
      public IWebElement lnkLogOff => driver.FindElement(By.LinkText("Log off"));

        public void ClickLogIn() => lnkLogIn.Click();
        public bool IsLogOffExist() => lnkLogOff.Displayed;


    }
}
