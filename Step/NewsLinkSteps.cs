using System;
using TechTalk.SpecFlow;
using TestAutomationDemo.Base;
using TestAutomationDemo.Page;
using OpenQA.Selenium;


namespace TestAutomationDemo.Step


{
    [Binding]
    [Scope(Tag = "News")]
    public class NewsLinkSteps :SetUp
    {
        public IWebDriver Browser;
        public News news;

        [Given(@"I Navigate to BBC")]
        public void GivenINavigateToBBC()
        {
            Browser = driver;
            news = new News (Browser);
            news.NavigatetoBBC();
        }
        
        [Given(@"I Click on News")]
        public void GivenIClickOnNews()
        {
            news.ClickNews();

        }
        
        [Then(@"I see news page load successfully")]
        public void ThenISeeNewsPageLoadSuccessfully()
        {
            news.Checknewspage();
        }

        [Then(@"I Click on Sports")]
        public void ThenIClickOnSports()
        {
            news.ClickSports();
        }

        [Then(@"I see sports page load successfully")]
        public void ThenISeeSportsPageLoadSuccessfully()
        {
            news.CheckSportsPage();
        }


    }
}
