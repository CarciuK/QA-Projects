using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Test.DemoSite.PagesDemoSite
{
    public class EmployeePage : BaseDriverPage
    {

        IWebElement lnkEmployeeList => driver.FindElement(By.LinkText("Employee List"));
        IWebElement txtSearch => driver.FindElement(By.Name("searchTerm"));
        IWebElement btnSearch => driver.FindElement(By.CssSelector(".btn-default"));

        public void ClickEmployeeList() => lnkEmployeeList.Click();

        public void EnterName(string Name)
        {
            txtSearch.SendKeys(Name);
        }


        public void ClickSearch()
        {
            btnSearch.Click();
        }

    }
}
