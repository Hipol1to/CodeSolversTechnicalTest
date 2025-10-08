using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForCodeSolvers.Pages
{
    public class InventoryPage : BasePage
    {
        public InventoryPage(ChromeDriver driver) : base(driver)
        { }
        private readonly By PageTitle = By.ClassName("title");
        public string GetInventoryPageTitle()
        {
            string currentTitle = Driver.FindElement(PageTitle).Text;
            return currentTitle;
        }
    }
}
