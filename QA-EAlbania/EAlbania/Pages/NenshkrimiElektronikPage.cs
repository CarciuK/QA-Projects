using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_EAlbania.EAlbania.Pages
{
    public class NenshkrimiElektonikPage : BaseDriverPage
    {

        public IWebElement PerdorBTN => driver.FindElement(By.XPath("//*[@id=\"BodyContent_UseService\"]"));

        public IWebElement AplikimRiBTN => driver.FindElement(By.XPath("//*[@id=\"BodyContent_lnkNewApplication\"]"));
        public IWebElement VulaElektronikeShq => driver.FindElement(By.XPath("//*[@id=\"BodyContent_btn_Pajisje_Nenshkrim_Shqiptar\"]"));
        public IWebElement ProfesioniForm => driver.FindElement(By.Id("BodyContent_prof_licensave_titull"));
        public IWebElement NumriLicencesForm => driver.FindElement(By.Id("BodyContent_prof_licensave_numri"));
        public IWebElement SubjektiForm => driver.FindElement(By.Id("BodyContent_prof_licensave_subjekti"));
        public IWebElement Nipt => driver.FindElement(By.Id("BodyContent_prof_licensave_nipt"));
        public IWebElement Checkbox => driver.FindElement(By.Id("BodyContent_accept"));


        public void AplikimiRi_VulaElektronike()
        {

            PerdorBTN.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/form")));

            AplikimRiBTN.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/form")));

            VulaElektronikeShq.Click();

            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"ctl01\"]")));

            // Profili.Click();
            WebDriverWait wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));

            SelectElement Profili = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"BodyContent_profili\"]\r\n")));
            Profili.SelectByValue("1");

            ProfesioniForm.SendKeys("dasfgsvsdjvasfgasgf");

            NumriLicencesForm.SendKeys("123435");

            SubjektiForm.SendKeys("qdfgtrjkilyktjr");

            Nipt.SendKeys("X12345678X");
            WebDriverWait wait4 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));

            Checkbox.Click();




        }


        public void Aplikimi_Baza()
        {
            PerdorBTN.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/form")));

            AplikimRiBTN.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/form")));

            VulaElektronikeShq.Click();

            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"ctl01\"]")));

            // Profili.Click();
            WebDriverWait wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));

        }


        //Perzgjidh nje nga opsionet e dropdown-it
        public void ZgjidhProfilin(string value)
        {
            SelectElement Profili = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"BodyContent_profili\"]\r\n")));
            Profili.SelectByValue(value);
        }















    }
}