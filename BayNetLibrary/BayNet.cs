using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BayNetLibrary
{
    public class BayNet
    {
        private List<Node> nodes;

        public List<Node> Nodes
        {
            get { return nodes; }
            set { nodes = value; }
        }

        public BayNet()
        {
            nodes = new List<Node>();
        }

        public void AddNode(Node node)
        {
            nodes.Add(node);
        }

        public void AddData(List<Dictionary<int, int>> data)
        {
            foreach (var dictionary in data)
            {
                foreach (var nodedata in dictionary)
                {
                    Node node = this.nodes.SingleOrDefault(s => s.Id == nodedata.Key);

                    if (node != null)
                    {
                        node.AddEvent(dictionary);
                    }
                }
            }
        }

        public void printNetwork()
        {
            foreach (var node in nodes)
            {
                Console.WriteLine("NODE: " + node.Title + " (id: " + node.Id + ")");

                foreach (var outcome in node.Outcomes)
                {
                    Console.WriteLine("OUTCOME: " + outcome.Title);
                }

                foreach (var dependency in node.Dependencies)
                {
                    Console.WriteLine("DEPENDENCIES: " + dependency.Title);
                }

                Console.WriteLine("");

                Console.WriteLine("NODE PROBABILITY TABLE: ");
                node.NodeProbabilityTable.Print();

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("");
            }
        }
    }
}
