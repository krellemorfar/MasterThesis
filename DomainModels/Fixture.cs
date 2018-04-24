using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels
{
    public class Fixture
    {
        private int id;
        private string status;
        private int matchday;

        public int Id { get => id; set => id = value; }
        public string Status { get => status; set => status = value; }
        public int Matchday { get => matchday; set => matchday = value; }
    }
}
