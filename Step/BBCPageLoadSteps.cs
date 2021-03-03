using System;
using TechTalk.SpecFlow;
using TestAutomationDemo.Base;
using TestAutomationDemo.Page;
using OpenQA.Selenium;


namespace TestAutomationDemo.Step
{
    [Binding]
    [Scope(Tag= "BBCPageLoad")]
    public class BBCPageLoadSteps :SetUp
    {
        public IWebDriver Browser;
        public BBCPageLoads pageLoads;

        [Given(@"I navigate to BBC")]
        public void GivenINavigateToBBC()
        {
            Browser = driver;
            pageLoads = new BBCPageLoads(Browser);
            pageLoads.NavigateToBBC();
        }
        
        [Then(@"I see BBC page loads")]
        public void ThenISeeBBCPageLoads()
        {
            pageLoads.CheckPageLoads();
        }
    }
}
