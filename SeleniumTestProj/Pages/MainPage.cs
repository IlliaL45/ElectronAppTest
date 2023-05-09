using BoDi;
using SeleniumTestProj.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumTestProj.Pages
{
    class MainPage
    {
        private PageMap _pageMap;
        private WaitHelper _waitHelper;

        private By welcomeModal = By.XPath("//h5[text()='Welcome']/../..");
        private By closeWelcomeModalButton = By.XPath("//h5[text()='Welcome']/../button");
        private By newNotebookButton = By.XPath("//a[@id='newNotebookBtn']");
        private By newNotebookNameField = By.XPath("//input[@id='newNotebookNameInput']");
        private By newNotebookCreateButton = By.XPath("//input[@id='createNotebookButton']");
        private By notebooks = By.XPath("//ul[@id='notebookList']/li");

        public MainPage(IObjectContainer objectContainer, WaitHelper waitHelper)
        {
            _pageMap = new PageMap(objectContainer);
            _waitHelper = waitHelper;
        }

        public void CloseWelcomeModalButton()
        {
            _waitHelper.WaitElementDisplayed(welcomeModal);

            while (_pageMap.IsElementDisplayed(welcomeModal))
            {
                _pageMap.Click(closeWelcomeModalButton);
                _waitHelper.WaitElementHidden(welcomeModal);
            }
        }

        public void ClickNewNotebookButton()
        {
            _pageMap.Click(newNotebookButton);
        }

        public void TypeNewNotebookName(string name)
        {
            _pageMap.SendText(newNotebookNameField, name);
        }

        public void ClickCreateButton()
        {
            _pageMap.Click(newNotebookCreateButton);
        }

        public void AssertNotebookIsDisplayed(string expectedName)
        {
            Assert.Contains(expectedName, _pageMap.GetElementsText(notebooks));
        }
    }
}