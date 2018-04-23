using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

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

        public int Id { get => id; set => id = value; }
        public string Status { get => status; set => status = value; }
        public int Matchday { get => matchday; set => matchday = value; }
    }
}
