using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using Valtech.PAgeLibrary.Common;

namespace Valtech.PageLibrary.PageObjects
{
    internal class HomePage : Base
    {
        public bool latestNews(String userFullName)
        {
            IWebElement LatestNews = Driver.FindElement(By.XPath("//*[@id='container']/div[2]/div[3]/div[1]/header/h2"));
            string expectedText = userFullName.ToUpper();
            bool result = LatestNews.Text.Contains(expectedText);
            return result;
        }

        public HomePage NavigateToCareers()
        {
            IWebElement CareersPAge =
                Driver.FindElement(By.XPath("//*[@id='navigationMenuWrapper']/div/ul/li[5]/a/span"));
            CareersPAge.Click();
            return new HomePage();
        }

        public HomePage NavigateToServices()
        {
            IWebElement ServicesPAge =
                Driver.FindElement(By.XPath("//*[@id='navigationMenuWrapper']/div/ul/li[2]/a/span"));
            ServicesPAge.Click();
            return new HomePage();
        }

        public HomePage NavigateToWorks()
        {
            IWebElement worksPage = Driver.FindElement(By.XPath("//*[@id='navigationMenuWrapper']/div/ul/li[1]/a/span"));
            worksPage.Click();
            return new HomePage();
        }

        public HomePage NavigateToContacts()
        {
            IWebElement contactsIcon = Driver.FindElement(By.XPath("//*[@id='contacticon']/div/div/div[1]/i"));
            contactsIcon.Click();
            return new HomePage();
        }

        public IList<IWebElement> GetListOfCountries()
        {
            return Driver.FindElements(By.ClassName("contactcountry"));
        }

    }
}