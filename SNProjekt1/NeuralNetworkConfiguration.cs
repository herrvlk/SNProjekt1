using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SNProjekt1
{
    public abstract class NeuralNetworkConfiguration
    {
        // liczba wejść
        private int numberOfInputs;

        public int NumberOfInputs
        {
            get { return numberOfInputs; }
            set { numberOfInputs = value; }
        }

        // cykle nauki
        private int numberOfLearningCycles;

        public int NumberOfLearningCycles
        {
            get { return numberOfLearningCycles; }
            set { numberOfLearningCycles = value; }
        }

        // współczynnik uczenia (dla FeedForward)
        // początkowa wartość współczynnika nauki na wygrywającym neuronie (dla Kohonena)
        private double learningCoefficient;

        public double LearningCoefficient
        {
            get { return learningCoefficient; }
            set { learningCoefficient = value; }
        }
    }
}
