using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using FluentAssertions;
using OpenQA.Selenium.Support.PageObjects;

namespace TestAutomationDemo.Page
{
    public class Header
    {
        public IWebDriver Driver;

        public Header(IWebDriver browser)
        {
            Driver = browser;
            PageFactory.InitElements(Driver, this);
        }

       [FindsBy(How = How.LinkText, Using = "News")]
        public IWebElement Newslink;
      //  [FindsBy(How = How.LinkText, Using = "nw-o-news-branding")]
       // public IWebElement NewsPageLoad;
     //   string NewsUrl = "https://www.bbc.co.uk/news";


        [FindsBy(How = How.LinkText, Using = "Weather")]
        public IWebElement Weatherlink;
      //  [FindsBy(How = How.LinkText, Using = "nw-o-news-branding")]
       // public IWebElement WeatherPageLoad;

        string NewsUrl = "https://www.bbc.co.uk/news";
        string WeatherUrl = "https://www.bbc.co.uk/weather";

        public void NavigatetoBBC()
        {
            Driver.Navigate().GoToUrl("https://www.bbc.co.uk/");
        }

        public void ClickLink(String link)
        {
            switch (link)
            {
                case "News":
                    Newslink.Click();
                    break;
                case "Weather":
                    Weatherlink.Click();
                    break;
                default:
                    Console.WriteLine("WrongClick");
                    break;
            }
        }

        public void CheckPage(String link)
        {
            switch (link)
            {
                case "News":
                    Driver.Url.Contains(NewsUrl).Should().BeTrue();
                    break;
                case "Weather":
                    Driver.Url.Contains(WeatherUrl).Should().BeTrue();
                    break;
                default: 
                    Console.WriteLine("WrongUrl");
                    break;
            }
        }
    }
}
