using System;
using OpenQA.Selenium;
using PageObject.BaseEntities;
using PageObject.Pages.Components;

namespace PageObject.Pages
{
    public class AddProjectPage : BasePage
    {
        public static string EndPoint = "index.php?/admin/projects/add/1";

        private static readonly By AddProjectButtonBy = By.Id("accept");

        public AddProjectPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
            ProjectComponent = new ProjectComponent(driver);
        }
        
        public AddProjectPage(IWebDriver driver) : base(driver, false)
        {
            ProjectComponent = new ProjectComponent(driver);
        }
        
        protected override void OpenPage()
        {
            Driver.Navigate().GoToUrl(BaseTest.BaseUrl + EndPoint);
        }

        public override bool IsPageOpened()
        {
            try
            {
                return AddProjectButton.Displayed;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        
        public ProjectComponent ProjectComponent { get; set; }

        public IWebElement AddProjectButton => Driver.FindElement(AddProjectButtonBy) ;
    }
}