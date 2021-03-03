using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using TestAutomationDemo.Base;
using TestAutomationDemo.Page;


namespace TestAutomationDemo.StepUp
{
    [Binding]
    [Scope(Tag = "Header")]
    public class HeaderSteps :SetUp
    {
        public IWebDriver Browser;
        public Header header;

        [Given(@"I navigate to BBC")]
        public void GivenINavigateToBBC()
        {
            header.NavigatetoBBC();
            Browser = driver;
            header = new Header(Browser);
        }

        [When(@"I click on (.*)")]
        public void WhenIClickOnNews(string link)
        {
            header.ClickLink(link);
        }

        [Then(@"I see (.*)")]
        public void ThenISeeNews(string link)
        {
            header.CheckPage(link);
        }

    }
}
