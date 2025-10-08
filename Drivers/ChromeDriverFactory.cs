using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForCodeSolvers.Drivers
{
    public static class ChromeDriverFactory
    {

        private static ChromeDriver _driver;
        public static ChromeDriver GetDriver()
        {
            if (_driver != null)
                return _driver;

            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            _driver.Manage().Window.Maximize();
            return _driver;
        }
        public static void QuitDriver()
        {
            _driver.Quit();
            _driver = null;
        }
    }
}
