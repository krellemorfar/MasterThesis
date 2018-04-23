using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels
{
    public class Competition
    {
        private int id;
        private string caption;
        private LinkList _links;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Caption
        {
            get { return caption; }
            set { caption = value; }
        }

        public LinkList _Links
        {
            get { return _links; }
            set { _links = value; }
        }
    }
}
