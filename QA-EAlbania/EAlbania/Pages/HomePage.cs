using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_EAlbania.EAlbania.Pages
{
    public class HomePage : BaseDriverPage
    {
        IWebElement LogIn => driver.FindElement(By.XPath("//*[@id=\"navbarCollapse\"]/div/div[3]/div[4]/ul[1]/li[1]/a"));
        // IWebElement PopUp => driver.FindElement(By.XPath("//*[@id=\"swal2-content\"]/div/img"));

        public void ClickLogIn() => LogIn.Click();
        public void PopUpRemove() => new Actions(driver).MoveByOffset(0, 0).Click().Perform();

    }

}

