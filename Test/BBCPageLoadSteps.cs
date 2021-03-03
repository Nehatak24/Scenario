using System;
using TechTalk.SpecFlow;

namespace TestAutomationDemo.Test
{
    [Binding]
    public class BBCPageLoadSteps
    {
        [Given(@"I navigate to BBC")]
        public void GivenINavigateToBBC()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see BBC page loads")]
        public void ThenISeeBBCPageLoads()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
