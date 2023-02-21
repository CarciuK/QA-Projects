using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_EAlbania.EAlbania.Pages
{
    public class SherbimeShpejtaPage : BaseDriverPage
    {

        public IWebElement SearchBar => driver.FindElement(By.Id("searchBar"));

        public IWebElement SearchResult2 => driver.FindElement(By.XPath("/html/body/nav/div[3]/div/div[4]/div/form/div/div/div/div[2]"));

        #region Biznes Form
        public IWebElement RegjistroBiznesB => driver.FindElement(By.XPath("//*[@id=\"navbarCollapse\"]/div/div[3]/div[4]/ul[2]/li/a"));
        public IWebElement NUIS => driver.FindElement(By.Id("BodyContent_txtIdentifier"));

        public IWebElement Fjalekalimi => driver.FindElement(By.Id("BodyContent_txtPassword1"));

        public IWebElement Fjalekalimi2 => driver.FindElement(By.Id("BodyContent_txtPassword2"));

        public IWebElement EmriBisnesit => driver.FindElement(By.Id("BodyContent_txtOrganisationName"));

        public IWebElement PyetjaSigurise => driver.FindElement(By.Id("BodyContent_txtSecurityAnswer"));

        public IWebElement EmriBiznesit => driver.FindElement(By.Id("BodyContent_txtOrganisationName"));

        #endregion

        #region Ekstrakt Historik ne Menune e Vulave elektronike

        public IWebElement VulaelektronikeBTN => driver.FindElement(By.XPath("//*[@id=\"ctl01\"]/div[3]/div[1]/div[1]/div/h5"));
        public IWebElement EkstraktHistorik => driver.FindElement(By.XPath("//*[@id=\"container-services\"]/div[11]/div/div[1]/div[1]/h5"));
        public IWebElement PerdorBTN => driver.FindElement(By.XPath("//*[@id=\"BodyContent_UseService\"]"));
        public IWebElement NrNiptit => driver.FindElement(By.Id("BodyContent_txtNipt"));
        public IWebElement ShkarkoBtn => driver.FindElement(By.Id("BodyContent_Buttonshkarkod"));
        public IWebElement Mesazhi => driver.FindElement(By.XPath("//*[@id=\"swal2-content\"]"));

        #endregion

        public IWebElement PagesaElektronikeMenu => driver.FindElement(By.XPath("//*[@id=\"ctl01\"]/div[3]/div[1]/div[2]/div"));







        public void RegjistroBiznes()
        {

            RegjistroBiznesB.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"captcha6\"]")));





        }

        public void PlotesoBiznesForm()
        {

            NUIS.SendKeys("L12345678L");

            Fjalekalimi.SendKeys("kristinacarciu");

            Fjalekalimi2.SendKeys("kristinacarciu");

            PyetjaSigurise.SendKeys("Anila");

            EmriBisnesit.SendKeys("asdfghjkl");
        }



        public void KerkoSherbimin()
        {

            SearchBar.Click();
            SearchBar.SendKeys("Aplikim per");
            Thread.Sleep(3000);

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("searchBarautocomplete-list")));

            SearchResult2.Click();

        }



        public void VuleElektronike()
        {
            VulaelektronikeBTN.Click();
            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            Thread.Sleep(2000);

            EkstraktHistorik.Click();


            PerdorBTN.Click();

            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("BodyContent_txtNipt")));

            NrNiptit.SendKeys("L12345678L");

            Thread.Sleep(2000);

            ShkarkoBtn.Click();


        }


        public void PagesaElektronike() => PagesaElektronikeMenu.Click();








    }
}
