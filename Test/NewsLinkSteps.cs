using System;
using TechTalk.SpecFlow;

namespace TestAutomationDemo.Test
{
    [Binding]
    public class NewsLinkSteps
    {
        [Given(@"I Navigate to BBC")]
        public void GivenINavigateToBBC()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I Click on News")]
        public void GivenIClickOnNews()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see news page load successfully")]
        public void ThenISeeNewsPageLoadSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
