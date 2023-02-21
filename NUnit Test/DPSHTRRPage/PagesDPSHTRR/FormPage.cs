using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Test.DPSHTRRPage.PagesDPSHTRR
{


    public class FormPage : BaseDriverPage
    {

        //Aplikimi per Targen prove
        public void ClickApliko()
        {
            IJavaScriptExecutor executor1 = (IJavaScriptExecutor)driver;
            executor1.ExecuteScript("document.querySelector(\"#node-4666 > div > div.field.field-name-body.field-type-text-with-summary.field-label-hidden > div > div > p:nth-child(4) > a\").click()");
        }

        //Klikojme radio buttons te formes
        public void ClickAplikimRiRBTN()
        {
            IJavaScriptExecutor executor2 = (IJavaScriptExecutor)driver;
            executor2.ExecuteScript("document.querySelector(\"#edit-submitted-aplikimi > div:nth-child(2) > label\").click()");
        }

        //Arsyeja e aplikimit - radio button
        public void ClickArsyejaRBTN()
        {
            IJavaScriptExecutor executor3 = (IJavaScriptExecutor)driver;
            executor3.ExecuteScript("document.querySelector(\"#edit-submitted-arsyeja-aplikim > div:nth-child(1) > label\").click()");

        }


        //Plotesimi i formes me te dhenat
        //Emri Mbiemri
        public void EmriMbiemri()
        {
            IJavaScriptExecutor executor4 = (IJavaScriptExecutor)driver;
            executor4.ExecuteScript("document.querySelector(\"#edit-submitted-emri-i-subjektit-i-domosdoshem-subjekt-i-autorizuar-nga-prodhuesi-me-license-vii3b2-koncensionare\").value='Kristina Carciu';");
        }

        //Nipti
        public void Nipti()
        {
            IJavaScriptExecutor executor5 = (IJavaScriptExecutor)driver;
            executor5.ExecuteScript("document.querySelector(\"#edit-submitted-numri-i-nipt-it-i-domosdoshem\").value='xxxxxx';");
        }

        //Adresa
        public void Adresa()
        {
            IJavaScriptExecutor executor6 = (IJavaScriptExecutor)driver;
            executor6.ExecuteScript("document.querySelector(\"#edit-submitted-adresa-e-subjektit-i-domosdoshem\").value='Rruga e Dibres';");
        }

        //Administrator
        public void Admin()
        {
            IJavaScriptExecutor executor7 = (IJavaScriptExecutor)driver;
            executor7.ExecuteScript("document.querySelector(\"#edit-submitted-administratori-emer-mbiemer-i-domosdoshem\").value='John Doe';");
        }

        //NID
        public void NID()
        {
            IJavaScriptExecutor executor8 = (IJavaScriptExecutor)driver;
            executor8.ExecuteScript("document.querySelector(\"#edit-submitted-nid-i-domosdoshem\").value='K15903030P';");
        }

        //Tel
        public void Tel()
        {
            IJavaScriptExecutor executor9 = (IJavaScriptExecutor)driver;
            executor9.ExecuteScript("document.querySelector(\"#edit-submitted-numri-i-telefonit-celular-i-domosdoshem\").value='0677777777';");
        }

        //Email
        public void Email()
        {
            IJavaScriptExecutor executor10 = (IJavaScriptExecutor)driver;
            executor10.ExecuteScript("document.querySelector(\"#edit-submitted-email-i-i-domosdoshem\").value='kricarciu@gmail.com';");
        }

        //Targa
        public void Targa()
        {
            IJavaScriptExecutor executor11 = (IJavaScriptExecutor)driver;
            executor11.ExecuteScript("document.querySelector(\"#edit-submitted-numri-sasia-e-targave-1-deri-5-i-domosdoshem\").value='1';");
        }

        //KategoroiaRBTN
        public void KategoriaRadioBTN()
        {
            IJavaScriptExecutor executor12 = (IJavaScriptExecutor)driver;
            executor12.ExecuteScript("document.querySelector(\"#edit-submitted-police-sigurimi-tpl-kujdes-targa-e-proves-duhet-te-perdoret-vetem-me-mjetet-qe-perfshin-kategoria-tpl-qe-perzgjidhni > div:nth-child(1) > label\").click()");
        }

        //CheckBox
        public void CheckBox()
        {
            IJavaScriptExecutor executor13 = (IJavaScriptExecutor)driver;
            executor13.ExecuteScript("document.querySelector(\"#edit-submitted-pranoj-kushtet-i-domosdoshem-lexo-dispozitat-e-pergjithshme-1\").click()");
        }











    }
}
