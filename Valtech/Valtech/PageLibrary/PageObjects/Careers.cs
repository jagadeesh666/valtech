using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valtech.PAgeLibrary.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace Valtech.PageLibrary.PageObjects
{
    class Careers : Base
    {
        public bool CareersPageName(string CareersHeader)
        {
            IWebElement CareersPageName = Driver.FindElement(By.XPath("//*[@id='container']/div[1]/h1"));
            string expectedText = CareersHeader.ToUpper();
            string displayedtext = CareersPageName.Text.ToUpper();
            bool result = displayedtext.Contains(expectedText);
            return result;
        }
    }
}

