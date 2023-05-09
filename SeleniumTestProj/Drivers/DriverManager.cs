using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTestProj.Configuration;
using TechTalk.SpecFlow;

namespace SeleniumTestProj.Drivers
{
    [Binding]
    class DriverManager
    {
        private readonly IObjectContainer _objectContainer;
        private IWebDriver _webDriver;

        public DriverManager(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void InitializeDriver()
        {
            ChromeOptions _chromeOptions = new ChromeOptions();
            _chromeOptions.BinaryLocation = ConfigurationLoader.Settings.AppPath;
            _webDriver = new ChromeDriver(_chromeOptions);
            _objectContainer.RegisterInstanceAs(_webDriver);
        }

        [AfterScenario]
        public void CleanUp()
        {
            _webDriver.Quit();
        }
    }
}