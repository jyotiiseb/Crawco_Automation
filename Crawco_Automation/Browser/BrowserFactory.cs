using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using RemoteDriver = Crawco_Automation.Driver.Driver;

namespace Crawco_Automation.Browser
{
    public class BrowserFactory : RemoteDriver
    {
        public static void GetChrome()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("--incognito");
            _Driver = new ChromeDriver(Directory.GetParent(Assembly.GetExecutingAssembly().Location).FullName, chromeOptions);
        }
    }
}