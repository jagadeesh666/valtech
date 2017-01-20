using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using Valtech.Stepdefinition;

namespace Valtech.PAgeLibrary.Common
{
    public class Base
    {
        public static IWebDriver Driver;
        public static string BaseUrl, UserName, Password, UserFullName;
        public static IWebDriver Instance { get; set; }

        public void NavigateTo(string url)
        {         
           Driver.Navigate().GoToUrl(url);
        }


        public void GetDriver()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            Driver = driver;
        }

        public void Close()
        {
            Driver.Quit();
        }
    }
}
