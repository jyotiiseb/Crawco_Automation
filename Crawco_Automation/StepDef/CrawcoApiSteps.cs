using Crawco_Automation.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Crawco_Automation.StepDef
{
    [Binding]
    internal class CrawcoApiSteps
    {
        private readonly RestHelper Rest = new RestHelper();
        private readonly ScenarioContext scenarioContext;

        CrawcoApiSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = ScenarioContext;
        }

        [Given(@"I have created a reqres request '(.*)' and save response as '(.*)'")]
        public void GivenIHaveCreatedAReqresRequestAndSaveResponseAs(int parameter, string responseAlias, object restEndpoint)
        {
            var apiUri = Configuration.ReqresApi;
            Rest.SetEndpoint(apiUri);
            Rest.GetQuery($"/{parameter}/");
            scenarioContext.Add();
        }

    }
}
