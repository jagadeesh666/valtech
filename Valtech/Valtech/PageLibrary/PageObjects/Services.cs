using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valtech.PAgeLibrary.Common;
using OpenQA.Selenium;

namespace Valtech.PageLibrary.PageObjects
{
    class Services: Base
    {
        public bool ServicesPageName(string servicesHeader)
        {
            IWebElement servicesPageName = Driver.FindElement(By.XPath("//*[@id='container']/section/div[1]/a[1]"));
            string expectedText = servicesHeader.ToUpper();
            string displayedtext = servicesPageName.Text.ToUpper();
            bool result = displayedtext.Contains(expectedText);
            return result;
        }

    }
}
