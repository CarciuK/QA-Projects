using NUnit.Framework;
using NUnit_Test.DemoSite.PagesDemoSite;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using LogInPage = NUnit_Test.DemoSite.PagesDemoSite.LogInPage;
using HomePages = NUnit_Test.DemoSite.PagesDemoSite.HomePages;

namespace NUnit_Test.DemoSite

{

    public class Tests : BaseDriverPage
    {


        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();

        }

        [Test, Order(1)]
        public void Test1()
        {

            OpenBrowser("https://testautomationpractice.blogspot.com/");
          

            //SearchBar
            CustomControl.EnterText(driver.FindElement(By.XPath("//*[@id=\"Wikipedia1_wikipedia-search-input\"]")), "YouYube");
            //SearchButton
            CustomControl.Click(driver.FindElement(By.XPath("//*[@id=\"Wikipedia1_wikipedia-search-form\"]/div/span[2]/span[2]/input")));
            //DropDownMenu-speed
            CustomControl.SelectByText(driver.FindElement(By.XPath("//*[@id=\"speed\"]")), "Fast");




            Assert.Pass();
        }



        [Test, Order(2)]
        public void LogInTest()
        {

            OpenBrowser("http://eaapp.somee.com/");
            
            HomePages homePage = new HomePages();
            LogInPage loginPage = new LogInPage();


            homePage.ClickLogIn();
            loginPage.EnterUserNameAndPassword("admin", "password");
            loginPage.ClickLogIn();


            Assert.That(homePage.IsLogOffExist(), Is.True);

        }






        [Test, Order(3)]
        public void EmployeeListTest()
        {
            OpenBrowser("http://eaapp.somee.com/");

            HomePages homePage = new HomePages();
            LogInPage loginPage = new LogInPage();
            EmployeePage employeePage = new EmployeePage();


            homePage.ClickLogIn();
            loginPage.EnterUserNameAndPassword("admin", "password");
            loginPage.ClickLogIn();
            employeePage.ClickEmployeeList();


        }



        [Test, Order(4)]
        public void SearchEmployeeTest()
        {
            OpenBrowser("http://eaapp.somee.com/");

            HomePages homePage = new HomePages();
            LogInPage loginPage = new LogInPage();
            EmployeePage employeePage = new EmployeePage();



            homePage.ClickLogIn();
            loginPage.EnterUserNameAndPassword("admin", "password");
            loginPage.ClickLogIn();
            employeePage.ClickEmployeeList();
            employeePage.EnterName("Gianni");
            employeePage.ClickSearch();


        }



        [Test, Order(5)]
        public void DatePicker()
        {
            OpenBrowser("https://testautomationpractice.blogspot.com/");


            //DatePicker
            FunctionsPage.EnterDate(driver.FindElement(By.XPath("//*[@id=\"datepicker\"]")), "11/10/2021");
            //SearchButton
            FunctionsPage.Click(driver.FindElement(By.XPath("//*[@id=\"datepicker\"]")));


            Assert.Pass();
        }




        [Test, Order(6)]
        public void DropDownMenu()
        {
            OpenBrowser("https://testautomationpractice.blogspot.com/");

            FunctionsPage functionsPage = new FunctionsPage();
            //DropDownMenu-speed
            functionsPage.SelectByText(driver.FindElement(By.XPath("//*[@id=\"speed\"]")), "Fast");
            //DropDownMenu-file
            functionsPage.SelectByText(driver.FindElement(By.XPath("//*[@id=\"files\"]")), "PDF file");
            //DropDownMenu-number
            functionsPage.SelectByText(driver.FindElement(By.XPath("//*[@id=\"number\"]")), "3");
            //DropDownMenu-gadget
            functionsPage.SelectByText(driver.FindElement(By.XPath("//*[@id=\"products\"]")), "Iphone");
            //DropDownMenu-animal
            functionsPage.SelectByText(driver.FindElement(By.XPath("//*[@id=\"animals\"]")), "Big Baby Cat");



            Assert.Pass();
        }



        [Test, Order(7)]
        public void SignUpTest()
        {
            OpenBrowser("https://testautomationpractice.blogspot.com/");

            SignUpPage signupPage = new SignUpPage();

            signupPage.Frame();
            signupPage.EnterUserInfo();
            Thread.Sleep(3000);


        }


        [Test, Order(8)]
        public void DragAndDropTest()
        {
            OpenBrowser("https://testautomationpractice.blogspot.com/");

            FunctionsPage functionsPage = new FunctionsPage();
            functionsPage.DragAndDrop();


        }





















        [TearDown]
        public void Close()
        {

            driver.Quit();
        }

    }
}