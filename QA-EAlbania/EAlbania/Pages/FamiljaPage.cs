using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_EAlbania.EAlbania.Pages
{
    public class FamiljaPage : BaseDriverPage
    {

        #region Certifikata Familjare
        public IWebElement CertifikateFamiljare => driver.FindElement(By.XPath("//*[@id=\"ctl01\"]/div[3]/div[2]/div[1]/div/div[1]/ul/li[2]"));

        #endregion

        #region Cartifikata Personale
        public IWebElement CertifikatePersonale => driver.FindElement(By.XPath("//*[@id=\"ctl01\"]/div[3]/div[2]/div[1]/div/div[1]/ul/li[1]"));
        public IWebElement AplikimVeteRBTN => driver.FindElement(By.XPath("//*[@id=\"BodyContent_rbLejePerVeten\"]"));
        #endregion

        #region Aplikim Adrese
        public IWebElement AplikimRiAdrese => driver.FindElement(By.XPath("//*[@id=\"BodyContent_btnNewApplication\"]"));
        public IWebElement DeklarimAdres => driver.FindElement(By.XPath("//*[@id=\"ctl01\"]/div[3]/div[2]/div[1]/div/div[1]/ul/li[3]"));

        //Formulari
        public IWebElement Shteti => driver.FindElement(By.XPath("//*[@id=\"BodyContent_DdlCountryAuth\"]"));
        public IWebElement KodiPostar => driver.FindElement(By.XPath("//*[@id=\"BodyContent_txtPostalCodeAuth\"]"));
        public IWebElement Qyteti => driver.FindElement(By.XPath("//*[@id=\"BodyContent_txtCityAuth\"]"));
        public IWebElement Rruga => driver.FindElement(By.XPath("//*[@id=\"BodyContent_txtRoadAuth\"]"));
        public IWebElement Numri => driver.FindElement(By.XPath("//*[@id=\"BodyContent_txtNumberAuth\"]"));
        public IWebElement ElementeAdrese => driver.FindElement(By.XPath("//*[@id=\"BodyContent_txtOtherElementsAuth\"]"));
        public IWebElement Familjari => driver.FindElement(By.XPath("//*[@id=\"members_body\"]/tr[1]/td[6]"));
        public IWebElement NgarkoDokument => driver.FindElement(By.XPath("//*[@id=\"BodyContent_UdVertetimBanimiAuth\"]"));
        #endregion

        # region Te Tjera/Butona
        public IWebElement CertifikataLindjes => driver.FindElement(By.XPath("//*[@id=\"container-services\"]/div[2]/div/div[2]/div[1]"));
        public IWebElement TeTjera => driver.FindElement(By.XPath("//*[@id=\"ctl01\"]/div[3]/div[2]/div[1]/div/div[2]/a"));
        public IWebElement PerdorBTN => driver.FindElement(By.XPath("//*[@id=\"BodyContent_UseService\"]"));
        public IWebElement VazhdoBTN => driver.FindElement(By.XPath("//*[@id=\"swal2-content\"]/div/div[2]/div[3]/input"));
        #endregion



        public void C_Personale()

        {
            CertifikatePersonale.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"ctl01\"]/div[3]")));

            PerdorBTN.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[7]/div/div[2]")));

            VazhdoBTN.Click();


            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"ctl01\"]/div[3]")));

            AplikimVeteRBTN.Click();

            WebDriverWait wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait3.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"BodyContent_divContent\"]/div[2]/div")));



        }



        public void C_Familjare()

        {
            CertifikateFamiljare.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"ctl01\"]/div[3]/div/div/div[2]/div/div/div")));

            PerdorBTN.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"swal2-content\"]/div/div[2]")));

            VazhdoBTN.Click();


            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"BodyContent_divContent\"]/div[2]/div")));



        }



        public void DeklarimAdresa()

        {

            Thread.Sleep(2000);

            DeklarimAdres.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"ctl01\"]/div[3]/div/div/div[2]/div/div")));

            PerdorBTN.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"ctl01\"]")));

            AplikimRiAdrese.Click();


            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"ctl01\"]/div[3]/div[3]/div")));

            SelectElement selectmenu = new SelectElement(Shteti);
            selectmenu.SelectByValue("ALB");

            KodiPostar.SendKeys("1056");

            Qyteti.SendKeys("Tirane");

            Rruga.SendKeys("Rruga barrikadave");

            Numri.SendKeys("0677777777");

            ElementeAdrese.SendKeys("Rruga e barrikadave, Tirane");

            Familjari.Click();

            string path = @"C:\Users\carci\Desktop\Scanned Documents.pdf";
            NgarkoDokument.SendKeys(path);
            Thread.Sleep(5000);



        }

        public void FamiljaTeTjera()
        {

            TeTjera.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"container-services\"]")));

            CertifikataLindjes.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"divServiceInfo\"]")));

            PerdorBTN.Click();

            Thread.Sleep(2000);

            VazhdoBTN.Click();

            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"BodyContent_lblFinalMsg\"]")));





        }


    }
}
