using OpenQA.Selenium;

namespace PageObject.Core.Wrappers
{
    public class RadioOption
    {
        private readonly UIElement _uiElement;
        
        public RadioOption(IWebDriver driver, By by)
        {
            _uiElement = new UIElement(driver, by);
        }
        
        public RadioOption(IWebDriver driver, IWebElement webElement)
        {
            _uiElement = new UIElement(driver, webElement);
        }
        
        public void Click() => _uiElement.Click();

        public string Name => _uiElement.GetAttribute("name");
        public string Id => _uiElement.GetAttribute("id"); 
        public string Value => _uiElement.GetAttribute("value");
    }
}