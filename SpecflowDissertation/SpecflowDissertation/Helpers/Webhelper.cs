using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using static SeleniumExtras.WaitHelpers.ExpectedConditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace SpecflowDissertation.Helpers
{
    public static class Webhelper
    {
        [ThreadStatic]
        private static IWebDriver driver;

        public static IWebDriver Driver
        {
            get
            {
                return driver;
            }
            private set
            {
                driver = value;
            }
        }

        public static ChromeOptions SetChromeOptions()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            return chromeOptions;
        }


        public static void OpenBrowser(int implicitWaitTime = 0, bool isWindowsOnly = false)
        {
            Driver = new ChromeDriver(SetChromeOptions());
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
        }


        public static void endTest()
        {
            Driver.Quit();
            Driver.Dispose();
            Driver = null;

        }

    }
}
