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
    public sealed class TestSearchStepDefinition
    {
        static DriverFactory driverFactory = new DriverFactory();
        static IWebDriver driver = driverFactory.getDriver();
        HomePage home = new HomePage(driver);
        [Given(@"Click on search icon")]
        public void GivenClickOnSearchIcon()
        {
            home.GoToPage();
            driver.Manage().Window.Maximize();
            home.ClickOnSearchPicture();
        }

        [Given(@"Choose (.*) from frequent")]
        public void GivenChooseBLOCKCHAINFromFrequent(string XPass)
        {
            home.EnterData(XPass);
        }

        [When(@"I press enter")]
        public void WhenIPressEnter()
        {
            home.pressEnter();
        }

        [Then(@"I see all blogs about (.*)")]
        public void ThenISeeAllBlogsAboutBLOCKCHAIN(string url)
        {
            string pageUrl = driver.Url;
            Assert.AreEqual(url, pageUrl);
        }


        [Given(@"I have entered word ""(.*)""")]
        public void GivenIHaveEnteredWord(string p0)
        {
            home.EnterData(p0);
        }
        Search search = new Search(driver);
        [Then(@"I see ""(.*)""")]
        public void ThenISee(string p0)
        {
            Assert.IsTrue(search.CheckStrangeLabel(p0));
        }

        [Then(@"Near word ""(.*)""")]
        public void ThenNearWord(string p0)
        {
            Assert.IsTrue(search.CheckStrangeWord(p0));
            driver.Quit();
        }

    }
}
