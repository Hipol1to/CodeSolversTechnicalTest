using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestForCodeSolvers.Drivers;

namespace TestForCodeSolvers.Hooks
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            
            ChromeDriverFactory.GetDriver();
            
        }
        [AfterScenario]
        public void AfterScenario()
        {
            
            ChromeDriverFactory.QuitDriver();
            
        }
    }
}
