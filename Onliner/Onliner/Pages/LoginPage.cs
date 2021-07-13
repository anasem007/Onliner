using OpenQA.Selenium;
using PageObject.BaseEntities;

namespace Onliner.Pages
{
    public class LoginPage : BasePage
    {
        private static readonly By LoginBy = By.CssSelector("button.auth-button");

        private static readonly By EmailBy =
            By.XPath("//div[contains(@class, 'auth-form__label')]/following-sibling::div//input");

        private static readonly By
            PasswordBy = By.XPath("//div[contains(@class, 'insecure')]/preceding-sibling::input");

        public LoginPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }

        protected override void OpenPage()
        {
            throw new System.NotImplementedException();
        }

        public override bool IsPageOpened()
        {
            throw new System.NotImplementedException();
        }
    }
}