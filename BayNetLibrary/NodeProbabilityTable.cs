using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BayNetLibrary
{
    public class NodeProbabilityTable
    {
        private List<NodeProbabilityRow> rows;

        public NodeProbabilityTable(List<Outcome> outcomes, List<Node> dependencies)
        {
            this.rows = new List<NodeProbabilityRow>();

            // this should be > 0 when ready
            if (dependencies.Count > 0)
            {
                List<List<Outcome>> temp = new List<List<Outcome>>();

                foreach (Node node in dependencies)
                {
                    temp.Add(node.Outcomes);
                }

                IEnumerable<IEnumerable<Outcome>> result = Lol(temp);

                foreach (var item in result)
                {
                    List<Outcome> depOutcomes = new List<Outcome>();

                    foreach (var deoOutcome in item)
                    {
                        depOutcomes.Add(deoOutcome);
                    }

                    NodeProbabilityRow tmp = new NodeProbabilityRow(outcomes, depOutcomes);
                    this.rows.Add(tmp);
                }
            }
            else
            {
                NodeProbabilityRow npr = new NodeProbabilityRow(outcomes);
                this.rows.Add(npr);
            }
        }

        public static IEnumerable<IEnumerable<Outcome>> Lol(IEnumerable<IEnumerable<Outcome>> sequences)
        {
            IEnumerable<IEnumerable<Outcome>> result = new[] {  Enumerable.Empty<Outcome>() };

            foreach (var sequence in sequences)
            {
                var s = sequence;

                result =
                  from seq in result
                  from item in s
                  select seq.Concat(new[] { item });
            }

            return result;
        }

        public void AddEvent(Node node, Dictionary<int, int> data)
        {
            foreach (NodeProbabilityRow row in this.rows)
            {
                bool test = true;

                if (row.Dependencies.Count > 0)
                {
                    foreach (Outcome dependency in row.Dependencies)
                    {
                        if (!data.ContainsValue(dependency.Id))
                        {
                            test = false;
                        }
                    }
                }

                if (test)
                {
                    NodeProbabilityOutcome npo = row.NodeProbabilityOutcomes.SingleOrDefault(s => s.Outcome.Id == data[node.Id]);
                    npo.AddCount();
                }
            }

        }

        public void Print()
        {
            List<List<string>> data = new List<List<string>>();
            List<string> row = new List<string>();

            NodeProbabilityRow firstRow = this.rows.First();

            foreach (var test in firstRow.Dependencies)
            {
                row.Add("");
            }

            foreach (NodeProbabilityOutcome npo in firstRow.NodeProbabilityOutcomes)
            {
                row.Add(npo.Outcome.Title);
            }

            data.Add(row);

            foreach (NodeProbabilityRow npo in this.rows)
            {
                row = new List<string>();

                foreach (var item in npo.Dependencies)
                {
                    row.Add(item.Title);
                }

                foreach (var item in npo.NodeProbabilityOutcomes)
                {
                    row.Add(item.Count.ToString());
                }

                data.Add(row);
            }

            foreach (List<string> outputRow in data)
            {
                foreach (string outputColumn in outputRow)
                {
                    Console.Write("{0, -20}", outputColumn);
                }

                Console.WriteLine();
            }

            /*
           foreach (NodeProbabilityRow npr in rows)
           {
               Console.WriteLine("---------- NPR ----------");

               if(npr.Dependencies.Count > 0)
               {
                   foreach (Outcome outcome in npr.Dependencies)
                   {
                       Console.Write(outcome.Title + " ");
                   }
               }
               else
               {
                   Console.Write("(no dependencies)");
               }

               Console.Write(" - OUTCOMES: ");

               foreach (NodeProbabilityOutcome npo in npr.NodeProbabilityOutcomes)
               {
                   var number = npr.NodeProbabilityOutcomes.IndexOf(npo) + 1;

                   Console.Write(npo.Outcome.Title + " (count: " + npo.Count + ", value: " + npo.Probability + ")");

                   if(number < npr.NodeProbabilityOutcomes.Count)
                   {
                       Console.Write(" - ");
                   }
               }

               Console.WriteLine();
            }
            */
        }
    }
}
