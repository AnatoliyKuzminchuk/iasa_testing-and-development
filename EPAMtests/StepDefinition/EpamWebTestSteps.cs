using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using EPAMtests.PageObjects;
using OpenQA.Selenium;
using NUnit.Framework;

namespace EPAMtests.StepDefinition
{
    [Binding]
    public class EpamWebTestSteps
    {
        static DriverFactory driverFactory = new DriverFactory();
        static IWebDriver driver = driverFactory.getDriver();
        HomePage home = new HomePage(driver);
        Careers careers = new Careers(driver);
        ContactFormPage contact = new ContactFormPage(driver);
        [Given(@"I have open ""(.*)""")]
        public void GivenIHaveOpen(string p0)
        {
            home.GoToPage();
        }
        
        [When(@"I click on ""(.*)""")]
        public void WhenIClickOn(string p0)
        {
            if (p0 == "epam")
            {
                home.ClickOnEpamPicture();
            }
            if (p0 == "contact us")
            {
                driver.Manage().Window.Maximize();
                home.ClickOnContactBotton();
            }
            if (p0 == "Careers")
            {
                driver.Manage().Window.Maximize();
                home.Clickсareers();
            }
            if (p0 == "Learn MORE")
            {
                home.ClickLearnMore();
            }
            if (p0 == "How we do it")
            {
                driver.Manage().Window.Maximize();
                home.ClickHowWeDoIt();
            }
        }

        [Then(@"I see howedoit information page")]
        public void ThenISeeHowedoitInformationPage()
        {
            string pageUrl = "https://www.epam.com/how-we-do-it";
            Assert.AreEqual(driver.Url, pageUrl);
        }

        [Then(@"I see site refresh")]
        public void ThenISeeSiteRefresh()
        {
            string pageUrl = driver.Url;
            Assert.AreEqual(home.Url, pageUrl);
        }

        [When(@"I click on letter picture")]
        public void WhenIClickOnLetterPicture()
        {
            home.ClickOnContactBotton();
        }

        [Then(@"I see form to contact with ""(.*)""")]
        public void ThenISeeFormToContactWith(string p0)
        {
            string pageUrl = driver.Url;
            Assert.AreEqual(contact.Url, pageUrl);
        }
        
        [Then(@"I see form to find job offer in ""(.*)""")]
        public void ThenISeeFormToFindJobOfferIn(string p0)
        {
            string pageUrl = driver.Url;
            Assert.AreEqual(careers.Url, pageUrl);
            driver.Quit();
        }
        
        [Then(@"I see post about ""(.*)""")]
        public void ThenISeePostAbout(string p0)
        {
            string pageUrl = "https://www.epam.com/the-future-of-banking";
            Assert.AreEqual(driver.Url, pageUrl);
        }
    }
}
