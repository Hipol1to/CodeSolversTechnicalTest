using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForCodeSolvers.Pages
{
    public class BasePage
    {
        protected readonly ChromeDriver Driver;
        protected readonly WebDriverWait Wait;

        protected BasePage(ChromeDriver driver)
        {
            this.Driver = driver;
            this.Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }
        protected void Click(By locator)
        {
            Wait.Until(d => d.FindElement(locator).Displayed);
            Driver.FindElement(locator).Click();
        }
        protected void Type(By locator)
        {
            Wait.Until(d => d.FindElement(locator).Displayed);
            Driver.FindElement(locator).SendKeys("");
        }
        protected bool IsVisible(By locator)
        {
            try
            {
                return Driver.FindElement(locator).Displayed;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        protected void NavigateToSauceDemoPage()
        {
            Driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }
    }
}
