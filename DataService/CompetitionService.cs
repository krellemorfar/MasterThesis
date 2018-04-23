using System;
using System.Collections.Generic;
using System.Text;
using DomainModels;
using Newtonsoft.Json.Linq;

namespace DataService
{
    public class CompetitionService
    {
        public Competition GetCompetitionById(int id)
        {
            string url = "http://api.football-data.org/v1/competitions/" + id;

            Competition competition;

            using (var webClient = new System.Net.WebClient())
            {
                string rawJson = webClient.DownloadString(url);
                /*
                competition = Newtonsoft.Json.JsonConvert.DeserializeObject<Competition>(rawJson);
                */

                competition = new Competition();
                JObject json = JObject.Parse(rawJson);

                if (json.ContainsKey("id"))
                {
                    competition.Id = (int)json["id"];
                }

                if (json.ContainsKey("caotion"))
                {
                    competition.Caption = (string)json["caption"];
                }
            }

            return competition;
        }
    }
}
