using System;
using TechTalk.SpecFlow;
using TestAutomationDemo.Base;
using TestAutomationDemo.Page;
using OpenQA.Selenium;

namespace TestAutomationDemo.Step
{
    [Binding]
    [Scope(Tag ="DifferentUsers")]
    public class DifferentUsersSteps:SetUp
    {
        public IWebDriver Browser;
        public DifferentUsers differentUsers;

        [Given(@"I navigate to BMIPage")]
        public void GivenINavigateToBMIPage()
        {
            Browser = driver;
            differentUsers.Navigate();
        }

        [When (@"I enter (.*) and (.*)")]
        public void WhenIEnterAnd(string username, string password )
        {
            differentUsers.Login( username, password);
        }

        [Then(@"I am able to login successfully")]
        public void ThenIAmAbleToLoginSuccessfully()
        {
            differentUsers.CheckLogIn();
        }



    }
}
