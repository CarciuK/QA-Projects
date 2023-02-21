using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace NUnit_Test.DPSHTRRPage.PagesDPSHTRR
{
    public class MenuPage : BaseDriverPage
    {
        //Mjete Menu
        IWebElement hoverable1 = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[1]"));
        //Regjistrim menu
        IWebElement hoverable2 = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[1]/ul/li[2]/a"));
        //Mjeti i ri
        IWebElement hoverable3 = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[1]/ul/li[2]/ul/li[1]/a"));
        //Sherbime Menu
        IWebElement hoverable4 = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[4]/a"));
        //Menu Sherbime- Targa
        IWebElement hoverable5 = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[4]/ul/li[2]/a"));
        //Menu 3 Targa prove
        IWebElement hoverable6 = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[4]/ul/li[2]/ul/li[1]/a"));



        public void MenuMjete() => new Actions(driver).MoveToElement(hoverable1).Perform();            
        public void MenuRegjistrim() => new Actions(driver).MoveToElement(hoverable2).Perform();      
        public void MenuMjetiRiClick() => new Actions(driver).MoveToElement(hoverable3).Click().Perform();
        public void MenuSherbime() => new Actions(driver).MoveToElement(hoverable4).Perform();
        public void MenuSherbimeTarga() => new Actions(driver).MoveToElement(hoverable5).Perform();
        public void TargaProve() => new Actions(driver).MoveToElement(hoverable6).Click().Perform();
        



    }









}

