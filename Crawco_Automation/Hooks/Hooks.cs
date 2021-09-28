using Crawco_Automation.Browser;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Crawco_Automation.Hooks
{
    [Binding]
    public sealed class Hooks
    {

        [BeforeScenario]
        public void BeforeScenario(ScenarioContext scenarioContext)
        {
            BrowserProfile.SelectBrowser();
            BrowserProfile.SetImplicitWaitTimeout();
            BrowserProfile.SetPageLoadTimeOut();
            BrowserProfile.SetScriptTimeout();
            BrowserProfile.MaximizePage();
        }
                
        [AfterScenario]
        public void AfterScenario() => BrowserProfile.CloseBrowser();
        //Quit - Close all browsers
}
}
