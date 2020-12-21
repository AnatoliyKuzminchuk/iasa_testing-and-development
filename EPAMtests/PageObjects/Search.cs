using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAMtests.PageObjects
{
    class Search:HeaderFooter
    {
        public Search(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = @"//*[@id='main']/div[1]/div/section/div/div[2]/section/div[1]")]
        private IWebElement strangesearch;
        [FindsBy(How = How.XPath, Using = @"//*[@id='main']/div[1]/div/section/div/div[2]/section/div[2]/a")]
        private IWebElement nearword;
        public string Url = "https://www.epam.com/search";

        public bool CheckStrangeLabel(string label)
        {
            if (strangesearch.Text == label)
            {
                return true;
            }
            return false;
        }
        public bool CheckStrangeWord(string word)
        {
            if (nearword.Text == word)
            {
                return true;
            }
            return false;
        }
        public void goToPage()
        {
            driver.Navigate().GoToUrl(Url);
        }
    }
}
