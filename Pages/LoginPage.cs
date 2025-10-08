using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForCodeSolvers.Pages
{
    public class LoginPage :BasePage
    {
        public LoginPage(ChromeDriver driver) : base(driver) 
        {}
        private readonly By PageTitle = By.ClassName("login_logo");
        private readonly By UsernameTextField = By.Id("user-name");
        private readonly By PasswordTextField = By.Id("password");
        private readonly By LoginButton = By.Id("login-button");
        private readonly By LoginErrorLable = By.XPath("//*[@data-test='error']");
        public string GetPageTitle()
        {
            string currentTitle = Driver.FindElement(PageTitle).Text!;
            return currentTitle;
        }
        public bool IsHomePageTitleVisible()
        {
            return IsVisible(PageTitle);
        }
        public void NavigateToHomePage()
        {
            NavigateToSauceDemoPage();
        }
        public void LoginWithValidCredentials()
        {
            Type(UsernameTextField, "standard_user");
            Type(PasswordTextField, "secret_sauce");
            Thread.Sleep(100);
            Click(LoginButton);
        }
        public void LoginWithLockedOutCredentials()
        {
            Type(UsernameTextField, "locked_out_user");
            Type(PasswordTextField, "secret_sauce");
            Thread.Sleep(100);
            Click(LoginButton);
        }
        public string GetLoginErrorText()
        {
           string errorText = Driver.FindElement(LoginErrorLable).Text;
            return errorText;
        }
    }
}
