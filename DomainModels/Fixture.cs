using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainModels
{
    [Table("fixture")]
    public class Fixture
    {
        [Column("id")]
        private int id;

        [Column("status")]
        private string status;

        [Column("matchday")]
        private int matchday;

        /*
        private Team homeTeam;
        private Team awayTeam;
        */

        public Fixture()
        {

        }

        public Fixture(int matchday)
        {
            this.matchday = matchday;
        }

        public int Id { get => id; set => id = value; }
        public string Status { get => status; set => status = value; }
        public int Matchday { get => matchday; set => matchday = value; }
        //public Team HomeTeam { get => homeTeam; set => homeTeam = value; }
        //public Team AwayTeam { get => awayTeam; set => awayTeam = value; }

        public override string ToString()
        {
            return "Id " + id;
            //return "Id " + id + ": " + homeTeam.Name + " (" + homeTeam.Id + ") - " + awayTeam.Name + " (" + awayTeam.Id + ")  -  Status: " + status + " - Matchday: " + matchday;
        }
    }
}
