using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels
{
    public class LinkList
    {
        private Link self;
        private Link teams;
        private Link fixtures;
        private Link leagueTable;

        public Link Self { get => self; set => self = value; }
        public Link Teams { get => teams; set => teams = value; }
        public Link Fixtures { get => fixtures; set => fixtures = value; }
        public Link LeagueTable { get => leagueTable; set => leagueTable = value; }
    }
}
