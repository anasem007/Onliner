using System;
using OpenQA.Selenium;
using PageObject.BaseEntities;

namespace PageObject.Pages
{
    public class LoginPage : BasePage
    {
        private static string END_POINT = "";
        
        // Описание элементов

        private static readonly By EmailInputBy = By.Id("name");
        private static readonly By PswInputBy = By.Id("password");
        private static readonly By RememberMeCheckboxBy = By.Id("rememberme");
        private static readonly By LogInButtonBy = By.Id("button_primary");

        // Инициализация класса
        
        public LoginPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }
        
        public LoginPage(IWebDriver driver) : base(driver, false)
        {
        }

        protected override void OpenPage()
        {
            Driver.Navigate().GoToUrl(BaseTest.BaseUrl + END_POINT);
        }

        public override bool IsPageOpened()
        {
            try
            {
                return LoginButton.Displayed;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        // Методы

        public IWebElement EmailInput => Driver.FindElement(EmailInputBy);
        public IWebElement PswInput => Driver.FindElement(PswInputBy);
        public IWebElement RememberMeCheckbox => Driver.FindElement(RememberMeCheckboxBy);
        public IWebElement LoginButton => Driver.FindElement(LogInButtonBy);
        
    }
}