using NUnit.Framework;
using NUnit_Test.DPSHTRRPage;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V105.Runtime;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Test.Prove
{
  internal class CustomPage : BaseDriverPage
    {
  

        //Mjete Menu
        IWebElement hoverable1 = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[1]"));
        //Regjistrim menu
        IWebElement hoverable2 = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[1]/ul/li[2]/a"));
        //Mjeti i ri
        IWebElement hoverable3 = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[1]/ul/li[2]/ul/li[1]/a"));


        public void MenuMjete() => new Actions(driver).MoveToElement(hoverable1).Perform();
        public void MenuRegjistrim() => new Actions(driver).MoveToElement(hoverable2).Perform();
        public void MenuMjetiRiClick() => new Actions(driver).MoveToElement(hoverable3).Click().Perform();

   
      }

    public class TestingTests : BaseDriverPage
    {
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();

        }

        [Test, Order(1)]
        public void MjeteMenu()
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://www.dpshtrr.al/");

            CustomPage provePage = new CustomPage();
            provePage.MenuMjete();
            provePage.MenuRegjistrim();
            provePage.MenuMjetiRiClick();



        }

        [TearDown]
        public void Close()
        {

            driver.Quit();
        }



    }

}
