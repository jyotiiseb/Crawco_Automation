using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using RemoteDriver = Crawco_Automation.Driver.Driver;

namespace Crawco_Automation.Helpers
{
    class UIHelper : RemoteDriver
    {
        public void NavigateTo(string url) => _Driver.Navigate().GoToUrl(url);

        public static string AddTimeStamp(string text) => text + DateTime.Now.ToString("yyyyMMddHHmmssfff");
 
        public static void SelectElementByText(IWebElement element, string text)
        {
            new SelectElement(element)
                .SelectByText(text);
        }
    }
}