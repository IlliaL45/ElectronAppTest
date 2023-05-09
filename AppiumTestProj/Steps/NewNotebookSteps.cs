using AppiumTestProj.Pages;
using TechTalk.SpecFlow;

namespace AppiumTestProj.Steps
{
    [Binding]
    class NewNotebookSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private MainPage _mainPage;

        public NewNotebookSteps(ScenarioContext scenarioContext, MainPage mainPage)
        {
            _scenarioContext = scenarioContext;
            _mainPage = mainPage;
        }

        [Given(@"I click on New Notebook button")]
        public void GivenIClickOnNewNotebookButton()
        {
            _mainPage.AddNewNotebook();
        }

        [When(@"I create notebook with name '(.*)'")]
        public void GivenICreateNotebookWithName(string name)
        {
            _mainPage.TypeNewNotebookName(name);
            _mainPage.ClickCreateButton();
        }

        [Then(@"new Notebook with '(.*)' name is created")]
        public void ThenNewNotebookWithNameIsCreatedInNotebooksArea(string name)
        {
            _mainPage.AssertNotebookIsDisplayed(name);
        }

        [Then(@"I delete '(.*)' notebook")]
        public void ThenIDeleteNotebook(string name)
        {
            _mainPage.DeleteNotebook(name);
        }
    }
}
