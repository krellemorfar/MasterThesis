using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels
{
    class Team
    {
        private int id;
        private string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
