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
    public class News
    {
        public IWebDriver Driver;

        public News(IWebDriver browser)
        {
            Driver = browser;
            PageFactory.InitElements(Driver, this);
        }


        [FindsBy(How = How.LinkText, Using = "News")]
        public IWebElement Newslink;
        [FindsBy(How = How.LinkText, Using = "nw-o-news-branding")]
        public IWebElement NewsPageLoad;


        [FindsBy(How = How.LinkText, Using = "Sport")]
        public IWebElement SportsLink;
        [FindsBy(How = How.LinkText, Using = "sp-c-global-header__inner")]
        public IWebElement SportsPageLoad;


        string NewsUrl = "https://www.bbc.co.uk/news";
        string SportsUrl = "https://www.bbc.co.uk/sport";


        public void NavigatetoBBC()
        {
            Driver.Navigate().GoToUrl("https://www.bbc.co.uk/");
        }

        public void ClickNews()
        {
            Newslink.Click();
        }

        public void ClickSports()
        {
           SportsLink.Click();
        }


        public void Checknewspage()
        {
            Driver.Url.Contains(NewsUrl).Should().BeTrue();
        }

        public void CheckSportsPage()
        {
            Driver.Url.Contains(SportsUrl).Should().BeTrue();
        }



    }
}
