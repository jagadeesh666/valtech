using OpenQA.Selenium;
using Valtech.PAgeLibrary.Common;

namespace Valtech.PageLibrary.PageObjects
{
    internal class Works : Base
    {
        public bool WorksPageName(string worksHeader)
        {
            IWebElement worksPageName = Driver.FindElement(By.XPath("//*[@id='container']/section/div[1]/a[1]"));
            string expectedText = worksHeader.ToUpper();
            string displayedtext = worksPageName.Text.ToUpper();
            bool result = displayedtext.Contains(expectedText);
            return result;
        }
    }
}