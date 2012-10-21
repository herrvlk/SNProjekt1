using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SNProjekt1
{
    public class KohonenNetworkConfiguration : NeuralNetworkConfiguration
    {
        // liczba neuronów w poziomie
        private int numberOfHorizontalNeurons;

        public int NumberOfHorizontalNeurons
        {
            get { return numberOfHorizontalNeurons; }
            set { numberOfHorizontalNeurons = value; }
        }

        // liczba neuronów w pionie
        private int numberOfVerticalNeurons;

        public int NumberOfVerticalNeurons
        {
            get { return numberOfVerticalNeurons; }
            set { numberOfVerticalNeurons = value; }
        }

        // początkowy rozmiar sąsiedztwa
        private int initialSizeOfNeighborhood;

        public int InitialSizeOfNeighborhood
        {
            get { return initialSizeOfNeighborhood; }
            set { initialSizeOfNeighborhood = value; }
        }

        // współczynnik zmiany rozmiaru sąsiedztwa w czasie
        private double neighborhoodSizeChangeCoefficient;

        public double NeighborhoodSizeChangeCoefficient
        {
            get { return neighborhoodSizeChangeCoefficient; }
            set { neighborhoodSizeChangeCoefficient = value; }
        }

        // współczynnik zmiany współczynnika nauki w czasie
        private double learningCoefficientChange;

        public double LearningCoefficientChange
        {
            get { return learningCoefficientChange; }
            set { learningCoefficientChange = value; }
        }
    }
}
