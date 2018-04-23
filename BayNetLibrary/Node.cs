using System;
using System.Collections.Generic;
using System.Text;

namespace BayNetLibrary
{
    public class Node
    {
        private int id;
        private string title;
        private List<Outcome> outcomes;
        private List<Node> dependencies;
        private NodeProbabilityTable npt;

        public Node(int id, string title)
        {
            this.id = id;
            this.title = title;
            this.outcomes = new List<Outcome>();
            this.dependencies = new List<Node>();
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

        public List<Outcome> Outcomes
        {
            get { return outcomes; }
            set { outcomes = value; }
        }

        public NodeProbabilityTable NodeProbabilityTable
        {
            get { return npt; }
        }

        public void AddOutcome(Outcome outcome)
        {
            outcomes.Add(outcome);
        }

        public List<Node> Dependencies
        {
            get { return dependencies; }
            set { dependencies = value; }
        }

        public void AddDependency(Node node)
        {
            if (!dependencies.Contains(node))
            {
                dependencies.Add(node);
            }
        }

        public void AddEvent(Dictionary<int, int> data)
        {
            this.npt.AddEvent(this, data);
        }

        public void Generate()
        {
            this.npt = new NodeProbabilityTable(this.outcomes, this.dependencies);
        }
    }
}
