using System;
using System.Collections.Generic;
using System.Text;

namespace BayNetLibrary
{
    public class Outcome
    {
        private int id;
        private string title;

        public Outcome(int id, string title)
        {
            this.id = id;
            this.title = title;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
    }
}
