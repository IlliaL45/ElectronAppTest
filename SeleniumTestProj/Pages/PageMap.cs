using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace SeleniumTestProj.Pages
{
    class PageMap
    {
        private IWebDriver _webDriver;
        private WebDriverWait _wait;

        public PageMap(IObjectContainer objectContainer)
        {
            _webDriver = objectContainer.Resolve<IWebDriver>();
            _wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(5));
        }

        public void Click(By locator)
        {
            _wait.Until(d => d.FindElement(locator).Displayed && d.FindElement(locator).Enabled);
            try
            {
                _webDriver.FindElement(locator).Click();
            }
            catch (ElementClickInterceptedException)
            {
                _webDriver.FindElement(locator).Click();
            }
        }

        public void SendText(By locator, string text)
        {
            _wait.Until(d => d.FindElement(locator).Displayed);
            _webDriver.FindElement(locator).SendKeys(text);
        }

        public List<string> GetElementsText(By locator)
        {
            _wait.Until(d => d.FindElement(locator).Displayed);

            List<string> texts = new List<string>();
            foreach (IWebElement element in _webDriver.FindElements(locator))
            {
                texts.Add(element.Text);
            }
            return texts;
        }

        public bool IsElementDisplayed(By locator)
        {
            return _webDriver.FindElement(locator).Displayed;
        }
    }
}