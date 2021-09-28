using System;
using RemoteDriver = Crawco_Automation.Driver.Driver;
using BrowserType = Crawco_Automation.Configuration;

namespace Crawco_Automation.Browser
{
    public class BrowserProfile : RemoteDriver
    {

        public static void SelectBrowser()
        {
            switch (BrowserType.Browser)
            {
                case "Chrome":
                    BrowserFactory.GetChrome();
                    break;
                default:
                    throw new ArgumentException("No matching Browser found. Plesae check spelling and try again");
            }
        }

        public static void CloseBrowser() => _Driver.Quit();

        public static void SetImplicitWaitTimeout() => _Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        public static void SetPageLoadTimeOut() => _Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);

        public static void SetScriptTimeout() => _Driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(5);

        public static void MaximizePage() => _Driver.Manage().Window.Maximize();
    }
}