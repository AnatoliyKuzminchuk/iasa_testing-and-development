using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAMtests.PageObjects
{
    class Careers: HeaderFooter
    {
        public Careers(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public string Url = "https://www.epam.com/careers";

        [FindsBy(How = How.XPath, Using = "@//*[@id='_content_epam_en_about_who - we - are_contact_jcr_content_content - container_section_section - par_form_constructor']/div[3]/div/div[2]/button")]
        private IWebElement firstArticle;
        public void goToPage()
        {
            driver.Navigate().GoToUrl(Url);
        }
    }

}
