using System;
using System.Collections.Generic;
using System.Text;
using DomainModels;
using MySql.Data.MySqlClient;

namespace DatabaseService
{
    public class DbService
    {
        public void AddFixture(Fixture fixture)
        {
            using (var db = new FootballContext())
            {

            }
        }

        /*
        private string _connectionString;

        public DbService()
        {
            _connectionString = "server=mysql3.gigahost.dk;database=krellemorfar_masterthesis;uid=krellemorfar;pwd=Fckfck123;";
        }

        public Fixture GetFixture(int id)
        {
            FixtureService fixtureService = new FixtureService(_connectionString);
            return fixtureService.GetFixture(id);
        }

        public List<Fixture> GetFixtures()
        {
            FixtureService fixtureService = new FixtureService(_connectionString);
            return fixtureService.GetFixtures();
        }

        private Fixture CreateFixtureObject(MySqlDataReader dataReader)
        {
            Fixture fixture = new Fixture();

            fixture.Id = (int)dataReader["id"];
            fixture.Status = (string)dataReader["status"];
            fixture.Matchday = (int)dataReader["matchday"];

            fixture.HomeTeam = new Team((int)dataReader["hometeam"], (string)dataReader["hometeamname"]);
            fixture.AwayTeam = new Team((int)dataReader["awayteam"], (string)dataReader["awayteamname"]);

            return fixture;
        }
        */
    }
}
