﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels
{
    public class Team
    {
        private int id;
        private string name;

        public Team()
        {

        }

        public Team(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
