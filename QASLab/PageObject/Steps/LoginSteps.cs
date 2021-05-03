using OpenQA.Selenium;
using PageObject.BaseEntities;
using PageObject.Pages;
using PageObject.Services;

namespace PageObject.Steps
{
    public class LoginSteps : BaseStep
    {
        public LoginSteps(IWebDriver driver) : base(driver)
        {
        }
        public void Login()
        {
            var loginPage = new LoginPage(Driver, true);
            
            loginPage.EmailInput.SendKeys(Configurator.Username);
            loginPage.PswInput.SendKeys(Configurator.Password);
            loginPage.LoginButton.Click();
        }
    }
}