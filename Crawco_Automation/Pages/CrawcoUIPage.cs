using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crawco_Automation.Pages
{
    public class CrawcoUIPage : Driver.Driver
    {
        private IWebElement FaceBookLink => _Driver.FindElement(By.XPath("//a[@href = 'https://www.facebook.com/crawfordandco']"));

        public bool IsFaceBookLinkIsDisplayed() => FaceBookLink.Displayed;
    }
}
