using OpenQA.Selenium;
using PageObject.BaseEntities;
using PageObject.Enums;

namespace PageObject.Pages.Components
{
    public class ProjectComponent : BaseComponent
    {
        private static readonly By NameFieldBy = By.Id("name");
        private static readonly By AnnouncementFieldBy = By.Id("announcement");
        private static readonly By ShowAnnouncementCheckBoxBy = By.Id("show_announcement");

        private readonly ProjectTypeComponent _projectTypeComponent;

        public ProjectComponent(IWebDriver driver) : base(driver)
        {
            _projectTypeComponent = new ProjectTypeComponent(driver);
        }

        public IWebElement ProjectType(ProjectType type)
        {
            return type switch
            {
                Enums.ProjectType.Multiple => _projectTypeComponent.SuiteModeMultipleButton,
                Enums.ProjectType.SingleForAll => _projectTypeComponent.SuiteModeSingleButton,
                Enums.ProjectType.SingleBaseline => _projectTypeComponent.SuiteModeSingleBaselineButton,
                _ => null
            };
        }

        public IWebElement NameField => Driver.FindElement(NameFieldBy);
        public IWebElement AnnouncementField => Driver.FindElement(AnnouncementFieldBy);
        public IWebElement ShowAnnouncementCheckBox => Driver.FindElement(ShowAnnouncementCheckBoxBy);
    }
}