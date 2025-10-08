using OpenQA.Selenium.Chrome;
using TestForCodeSolvers.Drivers;
using TestForCodeSolvers.Pages;

namespace TestForCodeSolvers.StepDefinitions
{
    [Binding]
    public class TitleValidationStepDefinitions
    {
        private ChromeDriver _driver;
        private LoginPage _loginPage;
        private InventoryPage _inventoryPage;
        [Given("user navigates to sauce demo web page")]
        public void GivenUserNavigatesToSauceDemoWebPage()
        {
            _driver = ChromeDriverFactory.GetDriver();
            _loginPage = new LoginPage(_driver);
            _loginPage.NavigateToHomePage();
            bool isHomePageTitleVisible = _loginPage.IsHomePageTitleVisible();
            Assert.IsTrue(isHomePageTitleVisible);
        }

        [Then("the user should see the correct title")]
        public void ThenTheUserShouldSeeTheCorrectTitle()
        {
            _loginPage = new LoginPage(_driver);
            string currentPageTitle = _loginPage.GetPageTitle();
            string expectedPageTitle = "Swag Labs";
            Assert.AreEqual(currentPageTitle, expectedPageTitle);
        }
        [When("user logs in with valid credentials")]
        public void WhenUserLogsInWithValidCredentials()
        {
            _driver = ChromeDriverFactory.GetDriver();
            _loginPage = new LoginPage(_driver);
            _loginPage.LoginWithValidCredentials();
        }
        [When("user logs in with locked-out credentials")]
        public void WhenUserLogsInLockedOyutCredentials()
        {
            _driver = ChromeDriverFactory.GetDriver();
            _loginPage = new LoginPage(_driver);
            _loginPage.LoginWithLockedOutCredentials();
        }
        [Then("the page should show the locked-out error message")]
        public void ThenThePageShouldShowTheLockedOutErrorMessage()
        {
            _driver = ChromeDriverFactory.GetDriver();
            _loginPage = new LoginPage(_driver);
            string currentLoginErrorText = _loginPage.GetLoginErrorText();
            string expectedLoginErrorText = "Epic sadface: Sorry, this user has been locked out.";
            Assert.AreEqual(currentLoginErrorText, expectedLoginErrorText);
        }
        [Then("the user should be redirected to the inventory page")]
        public void ThenTheUserShouldBeRedirectedToTheInventoryPage()
        {
            _driver = ChromeDriverFactory.GetDriver();
            _inventoryPage = new InventoryPage(_driver);
            string currentPageTItle = _inventoryPage.GetInventoryPageTitle();
            string expectedPageTutle = "Products";
            Assert.AreEqual(currentPageTItle, expectedPageTutle);
        }
    }
}
