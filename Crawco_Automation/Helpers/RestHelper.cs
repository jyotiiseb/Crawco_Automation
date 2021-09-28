using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;

namespace Crawco_Automation.Helpers
{
    public class RestHelper
    {
        public RestClient endpoint = null;

        public RestClient SetEndpoint(string endpointUrl)
        {
            endpoint = new RestClient(endpointUrl);
            return endpoint;
        }

        public string GetQuery(string query)
        {
            var request = new RestRequest(query, Method.GET);
            IRestResponse response = endpoint.Execute(request);
            var content = response.Content; // raw content as string
            return content;
        }
    }
}
