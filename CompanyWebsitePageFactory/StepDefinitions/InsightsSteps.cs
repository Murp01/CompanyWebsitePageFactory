using System;
using TechTalk.SpecFlow;

namespace CompanyWebsitePageFactory.StepDefinitions
{

    [Binding]
    public class InsightsSteps
    {


        [Given(@"I am on the Linklaters homepage")]
        public void GivenIAmOnTheLinklatersHomepage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I click on Insights from the global navigation bar")]
        public void GivenIClickOnInsightsFromTheGlobalNavigationBar()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter a search term into Insights name search box")]
        public void WhenIEnterASearchTermIntoInsightsNameSearchBox()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"all results containing the search box will appear")]
        public void ThenAllResultsContainingTheSearchBoxWillAppear()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
