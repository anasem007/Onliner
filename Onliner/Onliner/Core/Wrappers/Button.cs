using OpenQA.Selenium;

namespace PageObject.Core.Wrappers
{
    public class Button
    {
        private UIElement _uiElement;
        
        public Button(IWebDriver driver, By @by)
        {
            _uiElement = new UIElement(driver, @by);
        }

        public void Click() => _uiElement.Click();
        public bool Enabled => _uiElement.Enabled;
    }
}