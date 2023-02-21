using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace NUnit_Test.DemoSite.PagesDemoSite
{
    public class FunctionsPage : BaseDriverPage
    {
        //DropDown menus
        IWebElement Speed = driver.FindElement(By.XPath("//*[@id=\"speed\"]"));
        IWebElement File = driver.FindElement(By.XPath("//*[@id=\"files\"]"));
        IWebElement Number = driver.FindElement(By.XPath("//*[@id=\"number\"]"));
        IWebElement Phone = driver.FindElement(By.XPath("//*[@id=\"products\"]"));
        IWebElement Animal = driver.FindElement(By.XPath("//*[@id=\"animals\"]"));

        //DragAndDrop 
        IWebElement from => driver.FindElement(By.XPath("//*[@id=\"draggable\"]"));
        IWebElement to => driver.FindElement(By.XPath("//*[@id=\"droppable\"]"));


        public static void EnterDate(IWebElement webElement, string value) => webElement.SendKeys(value);

        public static void Click(IWebElement webElement) => webElement.Click();

        public void SelectByText(IWebElement webelement, string text)
        {
            SelectElement selectmenu = new SelectElement(webelement);
            selectmenu.SelectByText(text);


        }



    //}

    
    //{
    //    SelectElement selectmenu = new SelectElement(Speed);
    //    selectmenu.SelectByText(Speed);
    //}

    //}
    //public void SelectByFile(IWebElement File, string text)
    //{
    //    SelectElement selectmenu = new SelectElement(File);
    //    selectmenu.SelectByText(text);

    //}
    //public static void SelectByNumber(IWebElement Number, string text)
    //{
    //    SelectElement selectmenu = new SelectElement(Number);
    //    selectmenu.SelectByText(text);

    //}
    //public static void SelectByPhone(IWebElement Phone, string text)
    //{
    //    SelectElement selectmenu = new SelectElement(Phone);
    //    selectmenu.SelectByText(text);

    //}
    //public static void SelectByAnimal(IWebElement Animal, string text)
    //{
    //    SelectElement selectmenu = new SelectElement(Animal);
    //    selectmenu.SelectByText(text);

    //}


    //DragAndDrop
    public void DragAndDrop()
        {

            Actions Drag = new Actions(driver);
            //Perform drag and drop
            Drag.DragAndDrop(from, to).Perform();


        }






    }


}
