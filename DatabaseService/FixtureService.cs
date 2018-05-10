using DomainModels;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseService
{
    internal class FixtureService
    {
        /*
        private MySqlConnection _conn;

        public FixtureService(string connectionString)
        {
            _conn = new MySqlConnection(connectionString);
        }

        public Fixture GetFixture(int id)
        {
            string query = "SELECT *, " +
                "(SELECT name FROM team WHERE id = f1.hometeam) AS hometeamname, " +
                "(SELECT name FROM team WHERE id = f1.awayteam) AS awayteamname FROM fixture f1 WHERE id = " + id;

            _conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, _conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                return CreateFixtureObject(dataReader);
            }

            dataReader.Close();
            _conn.Close();

            return null;
        }

        public List<Fixture> GetFixtures()
        {
            List<Fixture> fixtures = new List<Fixture>();

            string query = "SELECT *, " +
                "(SELECT name FROM team WHERE id = f1.hometeam) AS hometeamname, " +
                "(SELECT name FROM team WHERE id = f1.awayteam) AS awayteamname FROM fixture f1";

            _conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, _conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                fixtures.Add(CreateFixtureObject(dataReader));
            }

            dataReader.Close();
            _conn.Close();


            return fixtures;
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
