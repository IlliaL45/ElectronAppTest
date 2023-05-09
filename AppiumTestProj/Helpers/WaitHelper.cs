using OpenQA.Selenium.Appium.Windows;
using System;
using System.Diagnostics;
using System.Threading;

namespace AppiumTestProj.Helpers
{
    class WaitHelper
    {
        private WindowsDriver<WindowsElement> _winDriver;

        public WaitHelper(WindowsDriver<WindowsElement> winDriver)
        {
            _winDriver = winDriver;
        }

        public WindowsElement Until(Func<WindowsDriver<WindowsElement>, WindowsElement> func, TimeSpan? span = null)
        {
            WindowsElement element;
            TimeSpan timeSpan = span ?? TimeSpan.FromSeconds(4);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (stopwatch.Elapsed < timeSpan)
            {
                try
                {
                    element = func(_winDriver);
                    if (element != null)
                        return element;
                }
                catch
                {
                    Thread.Sleep(200);
                }
            }
            throw new TimeoutException("Failed to find element");
        }

        public void Until(Func<WindowsDriver<WindowsElement>, bool> func, TimeSpan? span = null)
        {
            TimeSpan timeSpan = span ?? TimeSpan.FromSeconds(4);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (stopwatch.Elapsed < timeSpan)
            {
                try
                {
                    if (func(_winDriver))
                        return;
                }
                catch
                {
                    Thread.Sleep(200);
                }
            }
            throw new TimeoutException("Failed to met condition");
        }
    }
}