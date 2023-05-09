using SeleniumTestProj.Pages;
using TechTalk.SpecFlow;

namespace SeleniumTestProj.Steps
{
    [Binding]
    class NewNotebookSteps
    {
        private MainPage _mainPage;

        public NewNotebookSteps(MainPage mainPage)
        {
            _mainPage = mainPage;
        }

        [Given(@"I close Welcome modal window")]
        public void GivenICloseWelcomeModalWindow()
        {
            _mainPage.CloseWelcomeModalButton();
        }

        [Given(@"I click on New Notebook button")]
        public void GivenIClickOnNewNotebookButton()
        {
            _mainPage.ClickNewNotebookButton();
        }

        [Given(@"I create notebook with name '(.*)'")]
        public void GivenICreateNotebookWithName(string name)
        {
            _mainPage.TypeNewNotebookName(name);
            _mainPage.ClickCreateButton();
        }

        [Then(@"new Notebook with '(.*)' name is created in Notebooks area")]
        public void ThenNewNotebookWithNameIsCreatedInNotebooksArea(string name)
        {
            _mainPage.AssertNotebookIsDisplayed(name);
        }
    }
}
