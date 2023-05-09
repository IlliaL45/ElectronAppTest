using AppiumTestProj.Helpers;
using BoDi;
using NUnit.Framework;

namespace AppiumTestProj.Pages
{
    class MainPage
    {
        private PageMap _pageMap;

        private AppiumBy fileButton = AppiumBy.Name("File");
        private AppiumBy newNotebookButton = AppiumBy.Name("New Notebook");
        private AppiumBy newNotebookNameField = AppiumBy.Name("Name: Name:");
        private AppiumBy newNotebookCreateButton = AppiumBy.Name("Create");
        private AppiumBy notebookByName(string name) => AppiumBy.Name($"{name}");
        private AppiumBy deleleteNotebookButton = AppiumBy.Name("Delete notebook");
        private AppiumBy deleleteButton = AppiumBy.Name("Delete");

        public MainPage(IObjectContainer objectContainer, WaitHelper waitHelper)
        {
            _pageMap = new PageMap(objectContainer);
        }

        public void AddNewNotebook()
        {
            _pageMap.Click(fileButton);
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
            Assert.IsTrue(_pageMap.IsElementDisplayed(notebookByName(expectedName)), $"New notebook {expectedName} is not displayed");
        }

        public void DeleteNotebook(string name)
        {
            _pageMap.RightClick(notebookByName(name));
            _pageMap.Click(deleleteNotebookButton);
            _pageMap.Click(deleleteButton);
        }
    }
}