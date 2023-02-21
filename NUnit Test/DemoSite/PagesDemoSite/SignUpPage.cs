using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Test.DemoSite.PagesDemoSite
{
    public class SignUpPage : BaseDriverPage
    {
        IWebElement txtFirstName => driver.FindElement(By.XPath("//*[@id=\"RESULT_TextField-1\"]"));
        IWebElement txtLastName => driver.FindElement(By.XPath("//*[@id=\"RESULT_TextField-2\"]"));
        IWebElement txtPhone => driver.FindElement(By.XPath("//*[@id=\"RESULT_TextField-3\"]"));
        IWebElement txtCountry => driver.FindElement(By.XPath("//*[@id=\"RESULT_TextField-4\"]"));
        IWebElement txtCity => driver.FindElement(By.XPath("//*[@id=\"RESULT_TextField-5\"]"));
        IWebElement txtEmail => driver.FindElement(By.XPath("//*[@id=\"RESULT_TextField-6\"]"));
        //Frame
        IWebElement iframe => driver.FindElement(By.XPath("//*[@id=\"frame-one1434677811\"]"));


        //IWebElement btnSignIn => driver.FindElement(By.CssSelector(""));

        public void EnterUserInfo()
        {

            txtFirstName.SendKeys("Krista");
            txtLastName.SendKeys("Carciu");
            txtPhone.SendKeys("067777777");
            txtCountry.SendKeys("Albania");
            txtCity.SendKeys("Tirane");
            txtEmail.SendKeys("Email@gmail.com");


        }

        public void Frame()
        {
            driver.SwitchTo().Frame(iframe);
        }



    }
}



