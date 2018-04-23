using System;
using System.Collections.Generic;
using System.Text;

namespace BayNetLibrary
{
    public class NodeProbabilityRow
    {
        private List<NodeProbabilityOutcome> npo;
        private List<Outcome> dependencies;

        public List<NodeProbabilityOutcome> NodeProbabilityOutcomes
        {
            get { return this.npo; }
        }

        public List<Outcome> Dependencies
        {
            get { return this.dependencies; }
        }

        public NodeProbabilityRow(List<Outcome> outcomes)
        {
            this.npo = new List<NodeProbabilityOutcome>();

            foreach (Outcome outcome in outcomes)
            {
                NodeProbabilityOutcome tmp = new NodeProbabilityOutcome(outcome);
                this.npo.Add(tmp);
            }

            this.dependencies = new List<Outcome>();
        }

        public NodeProbabilityRow(List<Outcome> outcomes, List<Outcome> dependencies)
        {
            this.npo = new List<NodeProbabilityOutcome>();

            foreach (Outcome outcome in outcomes)
            {
                NodeProbabilityOutcome tmp = new NodeProbabilityOutcome(outcome);
                this.npo.Add(tmp);
            }

            this.dependencies = dependencies;
        }
    }
}
