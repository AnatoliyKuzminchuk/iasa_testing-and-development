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
            driver = new ChromeDriver("packages/Selenium.WebDriver.ChromeDriver.87.0.4280.8800/driver/win32");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
    }
}
