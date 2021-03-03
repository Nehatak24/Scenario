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
    public class BBCPageLoads
    {
        public IWebDriver Driver;

        public BBCPageLoads(IWebDriver browser)
        {
            Driver = browser;
            PageFactory.InitElements(Driver, this);
        }

        string BBCUrl = "https://www.bbc.co.uk/";

         public void NavigateToBBC()
        {
            Driver.Navigate().GoToUrl("https://www.bbc.co.uk/");
        }

        public void CheckPageLoads()
        {
            Driver.Url.Contains(BBCUrl).Should().BeTrue();
        }
    }
}
