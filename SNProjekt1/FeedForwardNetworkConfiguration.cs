using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SNProjekt1
{
    public class FeedForwardNetworkConfiguration : NeuralNetworkConfiguration
    {
        // true - bias
        // false - no bias
        private bool bias;

        public bool Bias
        {
            get { return bias; }
            set { bias = value; }
        }

        // true - unipolar
        // false - bipolar
        private bool unipolar;

        public bool Unipolar
        {
            get { return unipolar; }
            set { unipolar = value; }
        }

        // liczba neuronów w warstwie ukrytej
        private int numberOfNeuronsInHiddenLayer;

        public int NumberOfNeuronsInHiddenLayer
        {
            get { return numberOfNeuronsInHiddenLayer; }
            set { numberOfNeuronsInHiddenLayer = value; }
        }

        // liczba wyjść
        private int numberOfOutputs;

        public int NumberOfOutputs
        {
            get { return numberOfOutputs; }
            set { numberOfOutputs = value; }
        }

        // współczynnik bezwładności
        private double inertiaCoefficient;

        public double InertiaCoefficient
        {
            get { return inertiaCoefficient; }
            set { inertiaCoefficient = value; }
        }
    }
}
