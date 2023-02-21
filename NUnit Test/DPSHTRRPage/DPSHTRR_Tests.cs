using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using NUnit_Test.DPSHTRRPage.PagesDPSHTRR;

namespace NUnit_Test.DPSHTRRPage
{
    public class DPSHTRR_Tests : BaseDriverPage
    {

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();

        }

        [Test, Order(1)]
        public void MenuMjete()
        {
            OpenBrowser("https://www.dpshtrr.al/");


            MenuPage menuPage = new MenuPage();
            menuPage.MenuMjete();
            menuPage.MenuRegjistrim();
            menuPage.MenuMjetiRiClick();

        }



        [Test, Order(2)]
        public void MenuSherbime()
        {
            OpenBrowser("https://www.dpshtrr.al/");

            MenuPage menuPage = new MenuPage();
            menuPage.MenuSherbime();
            menuPage.MenuSherbimeTarga();
            menuPage.TargaProve();



        }


        [Test, Order(3)]
        public void TargaProveForm()
        {
 
            OpenBrowser("https://www.dpshtrr.al/");

            MenuPage menuPage = new MenuPage();
            menuPage.MenuSherbime();
            menuPage.MenuSherbimeTarga();
            menuPage.TargaProve();

            FormPage formPage = new FormPage();
            formPage.ClickApliko();


            formPage.ClickAplikimRiRBTN();
            formPage.ClickArsyejaRBTN();

            //Plotesimi i formularit
            formPage.EmriMbiemri();
            formPage.Nipti();
            formPage.Adresa();
            formPage.Admin();
            formPage.NID();
            formPage.Tel();
            formPage.Email();
            formPage.Targa();
            formPage.KategoriaRadioBTN();
            formPage.CheckBox();

            Thread.Sleep(4000);


        }



        [Test, Order(3)]
        public void SearchLajme()
        {
            OpenBrowser("https://www.dpshtrr.al/");

            NewsPage newsPage = new NewsPage();
            newsPage.MenuNews();
            newsPage.ClickMenuLajme();

            newsPage.SearchbarText();
            newsPage.ClickSearchBtn();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            newsPage.SearchbarClear();

        }



        [Test, Order(4)]
        public void TestiTeorik()
        { 
            OpenBrowser("https://www.dpshtrr.al/");

            NewsPage newsPage = new NewsPage();
            newsPage.TestiTeorik();
            newsPage.Scroll();
            newsPage.ShfletoBTN();
            Thread.Sleep(8000);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            newsPage.FrameB();
            Thread.Sleep(2000);

            //Shfleto faqet e librit
            newsPage.NextBTN();
            newsPage.LastpageBTN();

            //AsertTitle
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            newsPage.AssertTitle();

        }














































        [TearDown]
        public void Close()
        {

            driver.Quit();
        }


    }
}
