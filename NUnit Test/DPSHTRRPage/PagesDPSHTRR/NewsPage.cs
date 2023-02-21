using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Test.DPSHTRRPage.PagesDPSHTRR
{
    public class NewsPage : BaseDriverPage
    {
        //Menus
        IWebElement hoverable10 = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[6]"));
        IWebElement hoverable20 = driver.FindElement(By.XPath("//*[@id=\"dexp-dropdown\"]/ul/li[6]/ul/li[5]/a"));
  


        public void MenuNews() => new Actions(driver).MoveToElement(hoverable10).Perform();
       
        //LajmeClick
        public void ClickMenuLajme() => new Actions(driver).MoveToElement(hoverable20).Click().Perform();
   
        //Searchbar 
        public void SearchbarText()
        {
            IJavaScriptExecutor executor2 = (IJavaScriptExecutor)driver;
            executor2.ExecuteScript("document.querySelector(\"#edit-keys\").value='Zëri Yt Dëgjohet për Muajin Tetor';");       
        }

        //SearchButton
        public void ClickSearchBtn()
        {
            IJavaScriptExecutor executor3 = (IJavaScriptExecutor)driver;
            executor3.ExecuteScript("document.querySelector(\"#edit-submit-lajme\").click()"); 
        }


        //Searchbar 
        public void SearchbarClear()
        {
            IJavaScriptExecutor executor2 = (IJavaScriptExecutor)driver;
            executor2.ExecuteScript("document.querySelector(\"#edit-reset\").click()");
        }





        //Testi Teorik
        public void TestiTeorik() => driver.FindElement(By.XPath("//*[@id=\"block-block-127\"]/div[2]/div/div[3]/a[1]")).Click();

        public void Scroll()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver; js.ExecuteScript("window.scrollBy(0,290)");
        }


        public void ShfletoBTN()
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("document.querySelector(\"#block-block-134 > div.content > div > div > div:nth-child(1) > div > p > a\").click()");
        }


        public void FrameB()
        {
            IWebElement iframe = driver.FindElement(By.XPath("//*[@id=\"node-18567\"]/div/div/div/div/iframe"));
            driver.SwitchTo().Frame(iframe);
        }


        public void NextBTN() => driver.FindElement(By.XPath("//*[@id=\"secondaryToolbarToggle\"]")).Click();
        public void LastpageBTN() => driver.FindElement(By.XPath("//*[@id=\"lastPage\"]")).Click();

        public void AssertTitle()
        {
            string ExpectedText = "Kërkesa për dëmshpërblim mund të paraqitet brenda dy vitesh nga momenti ";
            string ActualText = driver.FindElement(By.XPath("//*[@id=\"viewer\"]/div[215]/div[2]/div[2]")).Text.ToString();
            Assert.AreEqual(ExpectedText, ActualText);

        }















    }
}
