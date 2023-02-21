using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_EAlbania.EAlbania.Pages
{
    public class ArsimiPage : BaseDriverPage
    {

        public IWebElement PerdorBTN => driver.FindElement(By.XPath("//*[@id=\"BodyContent_UseService\"]"));
        public IWebElement TeTjera => driver.FindElement(By.XPath("//*[@id=\"ctl01\"]/div[3]/div[2]/div[2]/div/div[2]/a"));
        public IWebElement RegjistrimeMenu => driver.FindElement(By.XPath("//*[@id=\"3:15-5025\"]/div"));
        public IWebElement MaturaShteteroreMenu => driver.FindElement(By.Id("1049"));
        public IWebElement NotatMatures => driver.FindElement(By.XPath("//*[@id=\"container-services\"]/div[18]/div/div/div[1]"));
        public IWebElement Transferim => driver.FindElement(By.XPath("//*[@id=\"container-services\"]/div[57]/div/div[1]/div[1]/h5"));



        public void ArsimiMaturaShteterore()
        {
            TeTjera.Click();
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("1049")));

            MaturaShteteroreMenu.Click();
            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

            Thread.Sleep(4000);
        }

        public void NotatMaturesClick() => new Actions(driver).MoveToElement(NotatMatures).Click().Perform();


        public void PerdorButton() => PerdorBTN.Click();

        public void Diploma() => driver.FindElement(By.XPath("//*[@id=\"BodyContent_permbajtja\"]/div[1]/div/img"));



        public void ArsimiTransferime()
        {

            TeTjera.Click();
            WebDriverWait wait5 = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            Thread.Sleep(3000);
            new Actions(driver).MoveToElement(RegjistrimeMenu).Click().Perform();
            WebDriverWait wait6 = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait6.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"container-services\"]/div[57]/div")));

        }

        public void TransferimClick() => new Actions(driver).MoveToElement(Transferim).Click().Perform();


    }
}
