using OpenQA.Selenium;

namespace PageObject.Core.Wrappers
{
    public class DropDownOption
    {
        private UIElement _uiElement;
        private string value;
        
        public DropDownOption(IWebDriver driver, By @by)
        {
            _uiElement = new UIElement(driver, @by);
        }
        
        public DropDownOption(IWebDriver driver, IWebElement webElement)
        {
            _uiElement = new UIElement(driver, webElement);
        }
        
        public string Text => _uiElement.Text;
        public void Click() => _uiElement.Click();
    }
}