using BoDi;
using Crawco_Automation.Helpers;
using Crawco_Automation.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Crawco_Automation.StepDef
{
    [Binding]
    class CrawcoUISteps
    {
        private readonly CrawcoUIPage crawcoUIPage;
        private readonly ScenarioContext scenarioContext;

        public CrawcoUISteps(IObjectContainer objectContainer, ScenarioContext scenarioContext)
        {
            crawcoUIPage = objectContainer.Resolve<CrawcoUIPage>();
            this.scenarioContext = scenarioContext;
        }

        [Given(@"I have opened crawco home page")]
        public void GivenIHaveOpenedCrawcoHomePage()
        {
            var helper = new UIHelper();
            helper.NavigateTo(Configuration.ComputerDatabaseUrl);
        }

        [Then(@"I verify facebook page link")]
        public void ThenIVerifyFacebookPageLink()
        {
            Assert.True(crawcoUIPage.IsFaceBookLinkIsDisplayed(), "Facebook link is not displayed on home page");
        }
    }
}
