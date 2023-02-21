using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace InternProjects.Forms
{

    [TestClass]
    public class SignUp
    {
        [TestMethod]
        public void TA_SignUp()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://testautomationpractice.blogspot.com/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[4]/div[2]/div[2]/div[2]/div[2]/div[2]/div[2]/div/div[4]/div[1]/div")));


            //Switch to name frame
            IWebElement iframe = driver.FindElement(By.XPath("//*[@id=\"frame-one1434677811\"]"));           
            driver.SwitchTo().Frame(iframe);

            //Fill in info
            IWebElement Name = driver.FindElement(By.XPath("//*[@id=\"RESULT_TextField-1\"]"));
            Name.Click();          
            Name.SendKeys("Krista");


            IWebElement LastName = driver.FindElement(By.XPath("//*[@id=\"RESULT_TextField-2\"]"));
            LastName.Click();
            LastName.SendKeys("Carciu");

            IWebElement Phone = driver.FindElement(By.XPath("//*[@id=\"RESULT_TextField-3\"]"));
            Phone.Click();
            Phone.SendKeys("0677777777");

            IWebElement Country = driver.FindElement(By.XPath("//*[@id=\"RESULT_TextField-4\"]"));
            Country.Click();
            Country.SendKeys("Albania");


            IWebElement City = driver.FindElement(By.XPath("//*[@id=\"RESULT_TextField-5\"]"));
            City.Click();
            City.SendKeys("Tirana");

            IWebElement Email = driver.FindElement(By.XPath("//*[@id=\"RESULT_TextField-6\"]"));
            Email.Click();
            Email.SendKeys("kristacarciu@gmial.com");


            Thread.Sleep(2000);
            //Radio button click
            IWebElement Gender = driver.FindElement(By.CssSelector("#RESULT_RadioButton-7_1"));
            Gender.Click();








            //var Gender = driver.FindElement(By.CssSelector("#RESULT_RadioButton-7_1"));
            //Actions actions1 = new Actions(driver);
            //actions1.MoveToElement(Gender);
            //actions1.Click(Gender);
            //actions1.Perform();





            Thread.Sleep(5000);
            driver.Dispose();



        

    }
    }
}
