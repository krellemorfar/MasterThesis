using System;
using System.Collections.Generic;
using System.Text;

namespace BayNetLibrary
{
    public class NodeProbabilityOutcome
    {
        private Outcome outcome;
        private int count;
        private double probability;

        public Outcome Outcome
        {
            get { return this.outcome; }
            set { this.outcome = value; }
        }

        public double Probability
        {
            get { return this.probability; }
            set { this.probability = value; }
        }

        public int Count
        {
            get { return this.count; }
        }

        public NodeProbabilityOutcome(Outcome outcome)
        {
            this.outcome = outcome;
            this.count = 0;
            this.probability = 0;
        }

        public NodeProbabilityOutcome(Outcome outcome, int count, double probability)
        {
            this.outcome = outcome;
            this.count = count;
            this.probability = probability;
        }

        public void AddCount()
        {
            this.count = this.count + 1;
        }
    }
}
