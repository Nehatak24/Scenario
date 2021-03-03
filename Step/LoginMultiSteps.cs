using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using TestAutomationDemo.Base;
using TestAutomationDemo.Page;


namespace TestAutomationDemo.Step
{
    [Binding]
    [Scope(Tag = "LoginMulti")]
    public class LoginMultiSteps:SetUp
    {
        public IWebDriver Browser;
        public LoginMulti loginMulti;

        [Given(@"I navigate to BMIPage")]
        public void GivenINavigateToBMIPage()
        {
            Browser = driver;
            loginMulti = new LoginMulti(Browser);
        }
        
        [When(@"I enter  (.*) and (.*)")]
        public void WhenIEnterAnd(string username, string password)
        {
            loginMulti.Login(username , password);
        }
        
        [Then(@"I am logged in with that users successfully")]
        public void ThenIAmLoggedInWithThatUsersSuccessfully()
        {
            loginMulti.CheckLogIn();
        }
    }
}
