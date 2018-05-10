using DomainModels;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiService
{
    internal class FixtureService
    {
        /*
        public Fixture GetFixture(int id)
        {
            string url = "http://api.football-data.org/v1/fixtures/" + id;
            Fixture fixture;

            using (var webClient = new System.Net.WebClient())
            {
                string rawJson = webClient.DownloadString(url);

                fixture = new Fixture();
                JObject json = JObject.Parse(rawJson);

                if (json.ContainsKey("fixture"))
                {
                    JObject fixtureJson = (JObject)json["fixture"];

                    if (fixtureJson.ContainsKey("_links"))
                    {
                        JObject linksJson = (JObject)fixtureJson["_links"];

                        // find link of current element to get id
                        if (linksJson.ContainsKey("self"))
                        {
                            JObject selfJson = (JObject)linksJson["self"];

                            if (selfJson.ContainsKey("href"))
                            {
                                fixture.Id = Helper.GetIdByUrl((string)selfJson["href"]);
                            }

                            // find link of hometeam to get id
                            if (linksJson.ContainsKey("homeTeam"))
                            {
                                JObject homeTeamJson = (JObject)linksJson["homeTeam"];

                                if (homeTeamJson.ContainsKey("href"))
                                {
                                    Team homeTeam = new Team();
                                    homeTeam.Id = Helper.GetIdByUrl((string)homeTeamJson["href"]);

                                    if (fixtureJson.ContainsKey("homeTeamName"))
                                    {
                                        homeTeam.Name = (string)fixtureJson["homeTeamName"];
                                    }

                                    fixture.HomeTeam = homeTeam;
                                }
                            }

                            // find link of awayteam to get id
                            if (linksJson.ContainsKey("awayTeam"))
                            {
                                JObject awayTeamJson = (JObject)linksJson["awayTeam"];

                                if (awayTeamJson.ContainsKey("href"))
                                {
                                    Team awayTeam = new Team();
                                    awayTeam.Id = Helper.GetIdByUrl((string)awayTeamJson["href"]);

                                    if (fixtureJson.ContainsKey("awayTeamName"))
                                    {
                                        awayTeam.Name = (string)fixtureJson["awayTeamName"];
                                    }

                                    fixture.AwayTeam = awayTeam;
                                }
                            }
                        }
                    }

                    if (fixtureJson.ContainsKey("matchday"))
                    {
                        fixture.Matchday = (int)fixtureJson["matchday"];
                    }

                    if (fixtureJson.ContainsKey("status"))
                    {
                        fixture.Status = (string)fixtureJson["status"];
                    }
                }
            }

            return fixture;
        }
        */
    }
}
