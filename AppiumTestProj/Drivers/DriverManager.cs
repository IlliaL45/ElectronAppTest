using AppiumTestProj.Configuration;
using BoDi;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace AppiumTestProj.Drivers
{
    [Binding]
    class DriverManager
    {
        private readonly IObjectContainer _objectContainer;
        private static Process _winAppDriverProcess;
        private WindowsDriver<WindowsElement> _session;
        private const string AppDriverUrl = "http://127.0.0.1:4723";


        public DriverManager(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario(Order = 0)]
        public void StartWinDriver()
        {
            _winAppDriverProcess = new Process();
            _winAppDriverProcess.StartInfo.FileName = ConfigurationLoader.Settings.WinAppDriverPath;
            _winAppDriverProcess.Start();
        }

        [BeforeScenario(Order = 1)]
        public void InitializeSession()
        {
            AppiumOptions options = new AppiumOptions();
            options.AddAdditionalCapability("app", ConfigurationLoader.Settings.AppPath);
            _session = new WindowsDriver<WindowsElement>(new Uri(AppDriverUrl), options);
            _objectContainer.RegisterInstanceAs(_session);
        }

        [AfterScenario]
        public void CleanUp()
        {
            _session.Quit();
        }
    }
}