using System;
using BayNetLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterThesis
{
    class Program
    {
        static void Main(string[] args)
        {
            BayNet bayNet = new BayNet();

            Node rainNode = new Node(1, "Rain");
            rainNode.AddOutcome(new Outcome(1, "Rain"));
            rainNode.AddOutcome(new Outcome(2, "No rain"));
            rainNode.Generate();
            bayNet.AddNode(rainNode);

            Node sprinklerNode = new Node(2, "Sprinkler");
            sprinklerNode.AddOutcome(new Outcome(3, "Going"));
            sprinklerNode.AddOutcome(new Outcome(4, "No Sprinkler"));
            sprinklerNode.AddDependency(rainNode);
            sprinklerNode.Generate();
            bayNet.AddNode(sprinklerNode);

            Node grassWetNode = new Node(3, "Grass Wet");
            grassWetNode.AddOutcome(new Outcome(5, "Wet Grass"));
            grassWetNode.AddOutcome(new Outcome(6, "Not wet"));
            grassWetNode.AddDependency(rainNode);
            grassWetNode.AddDependency(sprinklerNode);
            grassWetNode.Generate();
            bayNet.AddNode(grassWetNode);

            // fill with test data
            List<Dictionary<int, int>> data = new List<Dictionary<int, int>>();

            Dictionary<int, int> element = new Dictionary<int, int>();
            element.Add(1, 1);
            element.Add(2, 4);
            element.Add(3, 5);
            data.Add(element);

            element = new Dictionary<int, int>();
            element.Add(1, 2);
            element.Add(2, 3);
            element.Add(3, 5);
            data.Add(element);

            element = new Dictionary<int, int>();
            element.Add(1, 2);
            element.Add(2, 3);
            element.Add(3, 5);
            data.Add(element);

            bayNet.addData(data);

            bayNet.printNetwork();
        }
    }
}
