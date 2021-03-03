using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using FluentAssertions;

namespace TestAutomationDemo.Page
{
    public class DifferentUsers
    {
        public IWebDriver Driver;
        public DifferentUsers(IWebDriver browser)
        {
            Driver = browser;
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.Id,Using ="edit-name")]
        public IWebElement Username;
        [FindsBy(How = How.Id, Using = "edit-pass")]
        public IWebElement Password;
        [FindsBy(How = How.Id, Using = "edit-submit")]
        public IWebElement LogInButton;

        string ExpectedUrl = "https://it.intouch.bmigroup.com/home";

        public void Navigate()
        {
            Driver.Navigate().GoToUrl("https://it.intouch.bmigroup.com/user/login");
        }

        public void Login(String username , String password)
        {
            Username.SendKeys(username);
            Password.SendKeys(password);
            LogInButton.Click();
        }

        public void CheckLogIn()
        {
            Driver.Url.Contains(ExpectedUrl).Should().BeTrue();
        }

    }
}
