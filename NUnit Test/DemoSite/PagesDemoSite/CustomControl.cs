using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Test.DemoSite.PagesDemoSite
{
    public class CustomControl : BaseDriverPage
    {


        public static void EnterText(IWebElement webElement, string value) => webElement.SendKeys(value);

        public static void Click(IWebElement webElement) => webElement.Click();

        public static void SelectByText(IWebElement webelement, string text)
        {

            SelectElement selectelement = new SelectElement(webelement);
            selectelement.SelectByText(text);
        }

    }

}

