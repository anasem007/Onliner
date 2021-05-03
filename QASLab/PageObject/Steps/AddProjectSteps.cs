using OpenQA.Selenium;
using PageObject.BaseEntities;
using PageObject.Enums;
using PageObject.Pages;

namespace PageObject.Steps
{
    public class AddProjectSteps : BaseStep
    {
        private AddProjectPage _addProjectPage;

        public AddProjectSteps(IWebDriver driver, AddProjectPage addProjectPage) : base(driver)
        {
            _addProjectPage = addProjectPage;
        }
        
        public void AddProject(string name, ProjectType type)
        {
            _addProjectPage.ProjectComponent.NameField.SendKeys(name);
            _addProjectPage.ProjectComponent.ProjectType(type).Click();
            _addProjectPage.AddProjectButton.Click();
        }
        
        
    }
}