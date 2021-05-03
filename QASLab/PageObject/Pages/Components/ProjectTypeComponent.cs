using OpenQA.Selenium;
using PageObject.BaseEntities;

namespace PageObject.Pages.Components
{
    public class ProjectTypeComponent : BaseComponent
    {

        private static readonly By SuiteModeSingleButtonBy = By.Id("suite_mode_single");
        private static readonly By SuiteModeSingleBaselineButtonBy = By.Id("suite_mode_single_baseline");
        private static readonly By SuiteModeMultipleButtonBy = By.Id("suite_mode_multi");

        public ProjectTypeComponent(IWebDriver driver) : base(driver)
        {
        }
        
        public IWebElement SuiteModeSingleButton => Driver.FindElement(SuiteModeSingleButtonBy);
        public IWebElement SuiteModeSingleBaselineButton => Driver.FindElement(SuiteModeSingleBaselineButtonBy);
        public IWebElement SuiteModeMultipleButton => Driver.FindElement(SuiteModeMultipleButtonBy);
    }
}