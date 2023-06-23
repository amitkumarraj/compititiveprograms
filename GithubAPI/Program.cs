using RestSharp;
using System;
using System.Collections.Generic;

namespace GithubAPI
{
    internal class Program
    {
        private static RestClient client = new RestClient("https://api.github.com/");
        static void Main(string[] args)
        {
            RestRequest request = new RestRequest("orgs/squad-hub/teams", Method.Get);

            request.AddHeader("Authorization", "token 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");
            request.AddHeader("Accept", "application/vnd.github.v3+json");
            var sdd = client.ExecuteAsync<List<Team>>(request).Result;
            //var response = client.Execute<List<Team>>(request);
            Console.WriteLine("Hello World!");
        }
    }

    public class Team
    {
        public string name { get; set; }
        public int id { get; set; }
        public string node_id { get; set; }
        public string slug { get; set; }
        public string description { get; set; }
        public string privacy { get; set; }
        public string url { get; set; }
        public string html_url { get; set; }
        public string members_url { get; set; }
        public string repositories_url { get; set; }
        public string permission { get; set; }
        public object parent { get; set; }

    }
}
