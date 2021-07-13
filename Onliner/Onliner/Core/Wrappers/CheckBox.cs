using OpenQA.Selenium;

namespace PageObject.Core.Wrappers
{
    public class CheckBox 
    {
        private readonly UIElement _uiElement;
        private IJavaScriptExecutor _javaScriptExecutor;

        public CheckBox(IWebDriver driver, By @by)
        {
            _uiElement = new UIElement(driver, @by);
            _javaScriptExecutor = (IJavaScriptExecutor) driver;
        }

        public void Click() => _uiElement.Click();

        public bool Selected => _uiElement.Selected;
        
    }
}