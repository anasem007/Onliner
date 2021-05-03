using NUnit.Framework;
using PageObject.BaseEntities;
using PageObject.Enums;
using PageObject.Pages;
using PageObject.Steps;

namespace PageObject.Tests
{
    public class AddProjectPageTest : BaseTest
    {
        private AddProjectPage _addProjectPage;
        private AddProjectSteps _addProjectSteps;

        public AddProjectPageTest(AddProjectPage addProjectPage, AddProjectSteps addProjectSteps)
        {
            _addProjectPage = addProjectPage;
            _addProjectSteps = addProjectSteps;
        }

        [OneTimeSetUp]
        public new void OneTimeSetUp()
        {
            var loginSteps = new LoginSteps(Driver);
            loginSteps.Login();
        }

        [Test]
        public void AddProject(string name, ProjectType type)
        {
            _addProjectSteps.AddProject(name, type);
        }
    }
}