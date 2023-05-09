using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumTestProj.Helpers
{
    class WaitHelper
    {
        private WebDriverWait _wait;

        public WaitHelper(IObjectContainer objectContainer)
        {
            IWebDriver _webDriver = objectContainer.Resolve<IWebDriver>();
            _wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(5));
        }

        public void WaitElementDisplayed(By locator)
        {
            _wait.Until(d => d.FindElement(locator).Displayed);
        }

        public void WaitElementHidden(By locator)
        {
            _wait.Until(d => d.FindElement(locator).Displayed == false);
        }
    }
}
