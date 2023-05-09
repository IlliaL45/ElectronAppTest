using OpenQA.Selenium.Appium.Windows;
using System;

namespace AppiumTestProj.Helpers
{
    static class AppiumExtensions
    {
        public static WindowsElement FindElement(this WindowsDriver<WindowsElement> session, AppiumBy locator)
        {
            try
            {
                return locator.FindBy switch
                {
                    "Name" => session.FindElementByName(locator.Value),
                    "ClassName" => session.FindElementByClassName(locator.Value),
                    "XPath" => session.FindElementByXPath(locator.Value),
                    _ => throw new Exception($"Search method by {locator.FindBy} is not supported"),
                };
            }
            catch (Exception e)
            {
                throw new Exception($"Unable to find element by locator: {locator.Value}", e);
            }
        }
    }
}