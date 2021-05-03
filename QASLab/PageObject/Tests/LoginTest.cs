using System;
using NUnit.Framework;
using OpenQA.Selenium;
using PageObject.BaseEntities;
using PageObject.Pages;
using PageObject.Steps;

namespace PageObject.Tests
{
    public class Tests : BaseTest
    {
        [Test]
        public void Test1()
        {
            var loginSteps = new LoginSteps(Driver);
            loginSteps.Login();
            
            Assert.AreEqual("All Projects - TestRail",Driver.Title);
            Assert.IsTrue(new DashboardPage(Driver).IsPageOpened());
        }
        
        [Test]
        public void Test2()
        {
            var loginSteps = new LoginSteps(Driver);
            loginSteps.Login();

            var element = _waitService.GetVisibleElement(By.Id("sidebar-projects-add"));
            
            Console.Out.WriteLine(element.Displayed);
        }
    }
}