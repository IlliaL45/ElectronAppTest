using AppiumTestProj.Helpers;
using BoDi;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Interactions;

namespace AppiumTestProj.Pages
{
    class PageMap
    {
        private WindowsDriver<WindowsElement> _winDriver;
        private WaitHelper _wait;

        public PageMap(IObjectContainer objectContainer)
        {
            _winDriver = objectContainer.Resolve<WindowsDriver<WindowsElement>>();
            _wait = new WaitHelper(_winDriver);
        }

        internal void Click(AppiumBy locator)
        {
            WindowsElement element = _wait.Until(d => d.FindElement(locator));
            Actions actions = new Actions(_winDriver);
            actions.Click(element).Perform();
        }

        internal void RightClick(AppiumBy locator)
        {
            WindowsElement element = _wait.Until(d => d.FindElement(locator));
            Actions actions = new Actions(_winDriver);
            actions.ContextClick(element).Perform();
        }

        public void SendText(AppiumBy locator, string text)
        {
            WindowsElement element = _wait.Until(d => d.FindElement(locator));
            Actions actions = new Actions(_winDriver);
            actions.SendKeys(element, text).Perform();
        }

        public bool IsElementDisplayed(AppiumBy locator)
        {
            try
            {
                _wait.Until(d => d.FindElement(locator).Displayed);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}