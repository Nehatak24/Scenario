using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using TestAutomationDemo.Base;
using TestAutomationDemo.Page;




namespace TestAutomationDemo.Step
{
    [Binding]
    [Scope(Tag = "Header")]
    public class HeaderSteps:SetUp
    {
        public IWebDriver Browser;
        public Header header;

        [Given(@"I navigate to BBC")]
        public void GivenINavigateToBBC()
        {
            Browser = driver;
            header = new Header(Browser);
            header.NavigatetoBBC();
        }
        
        [When(@"I click (.*)")]
        public void WhenIClick(string link)
        {
            header.ClickLink(link);
        }
        
        [Then(@"I am able to see (.*)")]
        public void ThenIAmAbleToSee(string link)
        {
            header.CheckPage(link);
        }
    }
}
