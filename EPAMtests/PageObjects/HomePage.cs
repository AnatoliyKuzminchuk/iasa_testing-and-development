using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAMtests.PageObjects
{
    class HomePage : HeaderFooter
    {
        public string Url = "https://www.epam.com/";
        public HomePage(IWebDriver driver):base(driver)
        {
            PageFactory.InitElements(driver, this);
        }
        
        public void GoToPage()
        {
            driver.Navigate().GoToUrl(Url);
        }

    }
}