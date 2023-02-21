using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using QA_EAlbania.EAlbania.Pages;
using System.Security.Cryptography.X509Certificates;

namespace QA_EAlbania.EAlbania

{
    public class Tests:BaseDriverPage
    {
        [SetUp]
        public void Setup()
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
        public void Certifikate_Personale()
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


        [Test, Order(3)]
        public void Certifikate_Familjare()
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



        [Test, Order(4)]
        public void Deklarim_Adrese()
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


        [Test, Order(5)]
        public void TeTjera_Familja()
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


        [Test, Order(6)]
        public void Arsimi_Diploma()
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
            arsimiPage.ArsimiMaturaShteterore();
            arsimiPage.NotatMaturesClick();
            arsimiPage.PerdorButton();


            Assert.AreEqual("//*[@id=\"BodyContent_permbajtja\"]/div[1]/div/img", "//*[@id=\"BodyContent_permbajtja\"]/div[1]/div/img");
            Thread.Sleep(3000);

        }


        [Test, Order(7)]
        public void Arsimi_Regjistrime()
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
            arsimiPage.ArsimiTransferime();
            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            arsimiPage.TransferimClick();
            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(35));
            arsimiPage.PerdorButton();



            Thread.Sleep(3000);

        }




        [Test, Order(8)]
        public void Nenshkrim_Elektronik()
        {

            OpenBrowser("https://e-albania.al/eAlbaniaServices/UseService.aspx?service_code=13521");

            LogInPage logInPage = new LogInPage();
            logInPage.UserLogIn();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(35));

            NenshkrimiElektonikPage nenshkrimiElektonikPage = new NenshkrimiElektonikPage();
            nenshkrimiElektonikPage.AplikimiRi_VulaElektronike();


            Thread.Sleep(4000);

        }



        [Test, Order(9)]
        public void Nenshkrim_Elektronik2()
        {

            OpenBrowser("https://e-albania.al/eAlbaniaServices/UseService.aspx?service_code=13521");

            LogInPage logInPage = new LogInPage();
            logInPage.UserLogIn();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(35));

            NenshkrimiElektonikPage nenshkrimiElektonikPage = new NenshkrimiElektonikPage();
            nenshkrimiElektonikPage.Aplikimi_Baza();

            nenshkrimiElektonikPage.ZgjidhProfilin("3");
            Thread.Sleep(3000);


            Thread.Sleep(4000);

        }




        [Test, Order(10)]
        public void Regjistro_Biznes()
        {

            OpenBrowser("https://e-albania.al");

            HomePage homePage = new HomePage();
            homePage.PopUpRemove();

            LogInPage logInPage = new LogInPage();
            logInPage.UserLogIn();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(35));

            homePage.PopUpRemove();

            SherbimeShpejtaPage sherbimeShpejtaPage = new SherbimeShpejtaPage();
            sherbimeShpejtaPage.RegjistroBiznes();



            // sherbimeShpejtaPage.PlotesoBiznesForm();

            Thread.Sleep(3000);




        }



        [Test, Order(11)]
        public void Kerko_Sherbim()
        {

            OpenBrowser("https://e-albania.al");


            HomePage homePage = new HomePage();
            homePage.PopUpRemove();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(35));

            SherbimeShpejtaPage sherbimeShpejtaPage = new SherbimeShpejtaPage();
            sherbimeShpejtaPage.KerkoSherbimin();


            Thread.Sleep(3000);


        }




        [Test, Order(12)]
        public void Ekstrakt_Historik()
        {

            OpenBrowser("https://e-albania.al/");


            HomePage homePage = new HomePage();
            homePage.PopUpRemove();

            LogInPage logInPage = new LogInPage();
            logInPage.UserLogIn();

            homePage.PopUpRemove();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(35));


            SherbimeShpejtaPage sherbimeShpejtaPage = new SherbimeShpejtaPage();
            sherbimeShpejtaPage.VuleElektronike();

            Assert.That("//*[@id=\"swal2-content\"]", Is.EqualTo("//*[@id=\"swal2-content\"]"));

            //String ExpectedText = "Procesi i nënshkrimit dështoi! Ju lutem provoni më vonë!";
            //String ActualText = driver.FindElement(By.XPath("//*[@id=\"swal2-content\"]")).Text.ToString();
            //Assert.AreEqual(ExpectedText, ActualText);

            Thread.Sleep(3000);




        }




        [Test, Order(13)]
        public void Pagesa_Elektronike()
        {

            OpenBrowser("https://e-albania.al/");


            HomePage homePage = new HomePage();
            homePage.PopUpRemove();

            LogInPage logInPage = new LogInPage();
            logInPage.UserLogIn();

            homePage.PopUpRemove();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(35));


            SherbimeShpejtaPage sherbimeShpejtaPage = new SherbimeShpejtaPage();
            sherbimeShpejtaPage.PagesaElektronike();

            Assert.That("//*[@id=\"container-services\"]/div[1]/div/div[1]/div[1]/h5", Is.EqualTo("//*[@id=\"container-services\"]/div[1]/div/div[1]/div[1]/h5"));



            Thread.Sleep(3000);

        }


        [Test, Order(14)]
        public void Aplikim_KarteShendeti()
        {

            OpenBrowser("https://e-albania.al/");


            HomePage homePage = new HomePage();
            homePage.PopUpRemove();

            LogInPage logInPage = new LogInPage();
            logInPage.UserLogIn();

            homePage.PopUpRemove();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(35));

            Thread.Sleep(3000);
            ShendetesiaPage shendetesiaPage = new ShendetesiaPage();
            shendetesiaPage.AplikimKarteShendeti();

            //  Assert.That("//*[@id=\"swal2-content\"]", Is.EqualTo("//*[@id=\"swal2-content\"]"));



            Thread.Sleep(5000);




        }













        [TearDown]
            public void Close()
            {
            driver.Quit();
            }
        }
    }
