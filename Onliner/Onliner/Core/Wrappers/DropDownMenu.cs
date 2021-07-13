using System;
using System.Collections.Generic;
using System.Linq;
using Onliner.Services;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PageObject.Services;

namespace PageObject.Core.Wrappers
{
    public class DropDownMenu
    {
        private readonly UIElement _uiElement;
        private readonly By _by; // //*[contains(@id,'Dropdown')] можно найти три дропдауна на главной страницы с помощью айди которое содержит DropDown с приставкой
        private WaitService _waits;
        private List<DropDownOption> _options = new List<DropDownOption>();

        public DropDownMenu(IWebDriver driver, By @by)
        {
            _waits = new WaitService(driver);
            _by = by;
            _uiElement = new UIElement(driver, by);
            
            foreach (var option in _uiElement.FindElements(By.TagName("li")))
            {
                _options.Add(new DropDownOption(driver, option));
            }
        }

        public void SelectByText(string text)
        {
            try
            {
                foreach (var option in _options.Where(option => option.Text.Contains(text)))
                {
                    option.Click();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new NotFoundException("No such element");
            }
        }

        /*public void SelectByValue(string value)
        {
            _selectElement.SelectByValue(value);
        }*/

        public void SelectById(int id)
        {
            
        }

        public bool Displayed => _uiElement.Displayed;
    }
}