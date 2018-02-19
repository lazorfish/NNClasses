using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;

namespace NeuralNetworkForHeigthData
{
    class NetworkManager
    {
        private int numInputs;

        public int NumInputs
        {
            get { return numInputs; }
            set { numInputs = value; }
        }

        private int numOutputs;

        public int NumOutputs
        {
            get { return numOutputs; }
            set { numOutputs = value; }
        }

        private int numHiddedNuerons;

        public int NumHiddenNeurons
        {
            get { return numHiddedNuerons; }
            set { numHiddedNuerons = value; }
        }
        private int numHiddenLayers;

        public int NumHiddenLayers
        {
            get { return numHiddenLayers; }
            set { numHiddenLayers = value; }
        }
        private Vector<double> Inputs { get; set; }
        public Vector<double> Outputs { get; set; }
        private Matrix<double> Hidden { get; set; } 
        public NetworkManager(int _numIns, int _numOuts, int _numHiddenNeurons, int _numHiddenLayers)
        {
            Inputs
        }


    }
}
