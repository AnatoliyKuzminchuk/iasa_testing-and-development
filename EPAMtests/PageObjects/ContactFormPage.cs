using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAMtests.PageObjects
{
    class ContactFormPage : HeaderFooter
    {

        public ContactFormPage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public string Url = "https://www.epam.com/about/who-we-are/contact";
        public void goToPage()
        {
            driver.Navigate().GoToUrl(Url);
        }
        
    }
}