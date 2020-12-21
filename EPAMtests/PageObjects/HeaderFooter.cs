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
    class HeaderFooter
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        public HeaderFooter(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = @"//*[@id='wrapper']/div[2]/div[1]/header/div/a")]
        private IWebElement epampicture;

        [FindsBy(How = How.XPath, Using = @"//*[@id='wrapper']/div[2]/div[2]/div/div/header/div/ul/li[1]/a")]
        private IWebElement letterpicture;

        [FindsBy(How = How.XPath, Using = @"//*[@id='wrapper']/div[2]/div[1]/header/div/ul/li[1]/a")]
        private IWebElement contactbutton;

        [FindsBy(How = How.XPath, Using = @"//*[@id='wrapper']/div[2]/div[1]/header/div/ul/li[3]/div/button")]
        private IWebElement searchicon;
        [FindsBy(How = How.XPath, Using = @"//*[@id='new_form_search']")]
        private IWebElement searchfield;
        private IWebElement learnmorebuuton;
        private IWebElement сareers;
        private IWebElement howwedoitlink;

        public void enterText(IWebElement element, String text)
        {
            element.SendKeys(text);
        }

        public string ClickOnEpamPicture()
        {
            epampicture.Click();
            return driver.Url;
        }
        public string ClickOnSearchPicture()
        {
            searchicon.Click();
            return driver.Url;
        }
        public void EnterData(string XPass)
        {
            searchfield.SendKeys(XPass);
        }
        public ContactFormPage ClickOnLetterPicture()
        {
            letterpicture.Click();
            return new ContactFormPage(driver);
        }

        public ContactFormPage ClickOnContactBotton()
        {
            contactbutton.Click();
            return new ContactFormPage(driver);
        }
        public Careers Clickсareers()
        {
            сareers = driver.FindElement(By.XPath(@"//*[@id='wrapper']/div[2]/div[1]/header/div/nav/ul/li[6]/span[1]/a"));
            сareers.Click();
            return new Careers(driver);
        }
        public string ClickHowWeDoIt()
        {
            howwedoitlink = driver.FindElement(By.XPath(@"//*[@id='wrapper']/div[2]/div[1]/header/div/nav/ul/li[2]/span/a"));
            howwedoitlink.Click();
            return driver.Url;
        }
        public string ClickLearnMore()
        {
            learnmorebuuton = driver.FindElement(By.XPath(@"//*[@id='main']/div[1]/div[2]/section/div/div/div/div[1]/div/div[5]/div/div/div/div/div/div/div/div/div/div[3]/div/a"));
            learnmorebuuton.Click();
            return driver.Url;
        }
        public void goToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public void pressEnter()
        {
            IWebElement currentElement = driver.SwitchTo().ActiveElement();
            currentElement.SendKeys(Keys.Return);
        }
        public void waitAndClick(IWebElement element)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            element.Click();
        }
    }
}
