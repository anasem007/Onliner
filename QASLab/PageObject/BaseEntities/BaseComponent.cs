using System;
using OpenQA.Selenium;

namespace PageObject.BaseEntities
{
    public class BaseComponent
    {
        [ThreadStatic] protected static IWebDriver Driver;

        public BaseComponent(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}