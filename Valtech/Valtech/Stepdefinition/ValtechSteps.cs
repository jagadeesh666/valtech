using System;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Valtech.PAgeLibrary.Common;
using Valtech.PageLibrary.PageObjects;
using NUnit.Framework;


namespace Valtech.Stepdefinition
{
    [Binding]
    public class ValtechSteps
    {
        readonly HomePage _homePage = new HomePage();
        readonly Careers _careers = new Careers();
        readonly Services _services = new Services();
        static readonly Base Basepage = new Base();
        private Works _works= new Works();

        private HomePage _contactsPage;

        [BeforeScenario]
        public static void Setup()
        {            
            Basepage.GetDriver();
            Basepage.NavigateTo(ConfigurationManager.AppSettings["baseUrl"]);
        }

        [AfterScenario]
        public static void Teardown()
        {
            
            Basepage.Close();
           
        }

        [Given(@"I am on Home Page and has '(.*)' displayed.")]
        public void GivenIAmOnHomePage(string latestnews)
        {

            var result = _homePage.latestNews(latestnews);
            Assert.IsTrue(result);
         }

        [When(@"I click on Careers tab.")]
        public void WhenIPressCareersPage()
        {
            _homePage.NavigateToCareers();
        }

        [Then(@"the page heading has '(.*)' displayed.")]
        public void ThenThePageHeadingShowsCareers(string header)
        {
            if (header == "careers")
            {
                var result = _careers.CareersPageName(header);
                Assert.IsTrue(result);
            }
            else if(header == "services")
            {
                var result = _services.ServicesPageName(header);
                Assert.IsTrue(result);
            }
            else if (header == "works")
            {
                var result = _works.WorksPageName(header);
                Assert.IsTrue(result);
            }

        }

        [When(@"I click on Services tab.")]
        public void WhenIPressservicesPage()
        {
            _homePage.NavigateToServices();
        }

        [When(@"I click on Works tab.")]
        public void WhenIPressWorksPage()
        {
            _homePage.NavigateToWorks();
        }

        [When(@"I click on Contacts icon.")]
        public void WhenIPressContactsPage()
        {
           _contactsPage = _homePage.NavigateToContacts();
        }

        [Then(@"the page should display (.*) countries")]
        public void ThenThePageShouldDisplayCountries(int noOfCountries)
        {
            var listOfCountries = _contactsPage.GetListOfCountries();

            Assert.AreEqual(noOfCountries, listOfCountries.Count);
        }

    }
}
