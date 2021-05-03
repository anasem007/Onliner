using NUnit.Framework;
using OpenQA.Selenium;
using PageObject.BaseEntities;
using PageObject.Core.Wrappers;
using PageObject.Steps;

namespace PageObject.Tests
{
    public class DropDownTest : BaseTest
    {

        [Test]
        public void Test1()
        {
            var loginSteps = new LoginSteps(Driver);
            loginSteps.Login();

            var dropDown = new DropDownMenu(Driver, By.Id("userDropdown"));
            dropDown.SelectByText("My Settings");
        }
        
        
        [Test]
        public void Test2()
        {
            var loginSteps = new LoginSteps(Driver);
            loginSteps.Login();
            Driver.FindElement(By.XPath("//span[@class='caret top-menu-highlight']")).Click();
            var dropDown = new DropDownMenu(Driver, By.Id("helpDropdown"));
            Assert.IsTrue(dropDown.Displayed);
          //  dropDown.SelectByText("Keyboard Shortcuts");
        }
    }
}