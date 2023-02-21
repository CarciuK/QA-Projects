using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using NUnit_Test.Cases.Pages;
using LogInPage = NUnit_Test.Cases.Pages.LogInPage;
using NUnit_Test.eAlbaniaCases.Pages;

namespace NUnit_Test.Cases
{
    public class TestCases : BaseDriverPage
    {

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }


        [Test, Order(1)]
        public void LogIn()
        {

            OpenBrowser("https://e-albania.al/");

            HomePage homePage = new HomePage();
            homePage.PopUpRemove();

            LogInPage logInPage = new LogInPage();
            logInPage.UserLogIn();

            String ExpectedText = "Kristina Çarçiu";
            String ActualText = driver.FindElement(By.XPath("/html/body/nav/div[3]/div/div[3]/div[4]/ul[1]/li[1]/a")).Text.ToString();
            Assert.AreEqual(ExpectedText, ActualText);


        }



        [Test, Order(2)]
        public void CertifikatePersonale()
        {

            OpenBrowser("https://e-albania.al/");

            HomePage homePage = new HomePage();
            homePage.PopUpRemove();

            LogInPage logInPage = new LogInPage();
            logInPage.UserLogIn();

            homePage.PopUpRemove();

            FamiljaPage familjaPage = new FamiljaPage();
            familjaPage.C_Personale();

            Thread.Sleep(3000);



        }


        [Test, Order(2)]
        public void CertifikateFamiljare()
        {

            OpenBrowser("https://e-albania.al/");

            HomePage homePage = new HomePage();
            homePage.PopUpRemove();

            LogInPage logInPage = new LogInPage();
            logInPage.UserLogIn();

            homePage.PopUpRemove();

            FamiljaPage familjaPage = new FamiljaPage();
            familjaPage.C_Familjare();

            Thread.Sleep(3000);



        }



        [Test, Order(3)]
        public void DeklarimAdrese()
        {

            OpenBrowser("https://e-albania.al/");

            HomePage homePage = new HomePage();
            homePage.PopUpRemove();

            LogInPage logInPage = new LogInPage();
            logInPage.UserLogIn();

            homePage.PopUpRemove();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"ctl01\"]/div[3]/div[2]/div[1]/div")));

            // Thread.Sleep(2000);

            FamiljaPage familjaPage = new FamiljaPage();
            familjaPage.DeklarimAdresa();

            Thread.Sleep(3000);



        }


        [Test, Order(4)]
        public void TeTjeraFamilja()
        {

            OpenBrowser("https://e-albania.al/");

            HomePage homePage = new HomePage();
            homePage.PopUpRemove();

            LogInPage logInPage = new LogInPage();
            logInPage.UserLogIn();

            homePage.PopUpRemove();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"ctl01\"]/div[3]/div[2]/div[1]/div")));


            FamiljaPage familjaPage = new FamiljaPage();
            familjaPage.FamiljaTeTjera();


            String ExpectedText = "Ju nuk keni asnjë pjestar në familjen tuaj të lindur pas vitit 2010!";
            String ActualText = driver.FindElement(By.XPath("//*[@id=\"BodyContent_lblFinalMsg\"]")).Text.ToString();
            Assert.AreEqual(ExpectedText, ActualText);



            Thread.Sleep(3000);


        }


        [Test, Order(5)]
        public void Regjistirme()
        {

            OpenBrowser("https://e-albania.al/");

        HomePage homePage = new HomePage();
        homePage.PopUpRemove();

        LogInPage logInPage = new LogInPage();
        logInPage.UserLogIn();

        homePage.PopUpRemove();

        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"ctl01\"]/div[3]/div[2]/div[1]/div")));


        ArsimiPage arsimiPage = new ArsimiPage();
        arsimiPage.Prove();


     

            Thread.Sleep(3000);

        }
        





        [TearDown]
        public void Close()
        {
            driver.Quit();
        }

    }
    }
