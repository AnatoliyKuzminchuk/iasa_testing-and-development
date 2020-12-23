using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EPAMtests.PageObjects
{
    public class DriverFactory
    {
        private IWebDriver driver;

        public IWebDriver getDriver()
        {
            if (driver == null)
            {
                setDriver();
            }
            return driver;
        }
        private void setDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
    }
}
