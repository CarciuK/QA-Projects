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
    public class ShendetesiaPage : BaseDriverPage
    {

        //#region Constructor(s)
        //public PunaPage(IWebDriver driver) : base(driver)
        //{

        //}
        //#endregion

        public IWebElement ShendetiMenu => driver.FindElement(By.XPath("/html/body/div[2]/form/div[3]/div[2]/div[4]/div/div[1]"));
        public IWebElement CertifikateVaksinimi => driver.FindElement(By.XPath("//*[@id=\"ctl01\"]/div[3]/div[2]/div[4]/div/div[1]/ul/li[2]"));
        public IWebElement KerkeseVaksinimi => driver.FindElement(By.XPath("//*[@id=\"ctl01\"]/div[3]/div[2]/div[4]/div/div[1]/ul/li[3]"));
        public IWebElement PerdorBTN => driver.FindElement(By.Id("BodyContent_UseService"));
        public IWebElement KartaShendetesise => driver.FindElement(By.XPath("/html/body/div[2]/form/div[3]/div/div[2]/div/div[1]/div/div"));
        public IWebElement AplikimPerKarteShendeti => driver.FindElement(By.XPath("/html/body/div[2]/form/div[4]/div[2]/div[24]/div/div[1]/div[1]"));

        public IWebElement VazhdoBTN => driver.FindElement(By.XPath("/html/body/div[7]/div/div[2]/div[1]/div/div[2]/div[2]/input"));
        public IWebElement StudentChckbx1 => driver.FindElement(By.XPath("//*[@id=\"BodyContent_CheckBox5\"]"));

        bool element => driver.FindElement(By.XPath("//*[@id=\"BodyContent_CheckBox5\"]")).Enabled;

        public IWebElement UploadFile => driver.FindElement(By.XPath("//*[@id=\"BodyContent_FileUploadd\"]"));

        //public IWebElement  => driver.FindElement(By.XPath(""));



        public void AplikimKarteShendeti()
        {
            //new Actions(driver).MoveToElement(ShendetiMenu).Click().Perform();

            ShendetiMenu.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("1055")));


            KartaShendetesise.Click();


            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(" //*[@id=\"container-services\"]/div[24]/div/div[1]/div[1]/h5")));


            new Actions(driver).MoveToElement(AplikimPerKarteShendeti).Click().Perform();

            PerdorBTN.Click();

            Thread.Sleep(3000);
            VazhdoBTN.Click();

            StudentChckbx1.Click();

            Thread.Sleep(3000);

            //// If checkbox student is selected continue with uploading doc
            if (element == true)

            {
                string path = @"C:\Users\carci\Desktop\Scanned Documents.pdf";
                UploadFile.SendKeys(path);
            }
            else
            {
                driver.Dispose();
            }





        }








    }
}
