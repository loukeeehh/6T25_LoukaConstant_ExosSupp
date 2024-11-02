using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T25_LoukaConstant_ExosSupp
{
    internal class Vehicule
    {
        private string _plaque;
        private string _marque;
        private string _model;
        private int _maxCapaReservoir;
        private double _nivJaugeCarburant;

        public Vehicule(string plaque, string marque, string model, int maxCapaReservoir, double nivJaugeCarburant)
        {
            _plaque = plaque;
            _marque = marque;
            _model = model;
            _maxCapaReservoir = maxCapaReservoir;
            _nivJaugeCarburant = nivJaugeCarburant;
        }


        public string Plaque
        {
            get { return _plaque; }
            //set { myVar = value; }
        }

        public string Marque
        {
            get { return _marque; }
            //set { myVar = value; }
        }

        public string Model
        {
            get { return _model; }
            //set { myVar = value; }
        }

        public int MaxCapaReservoir
        {
            get { return _maxCapaReservoir; }
            set { _maxCapaReservoir = value; }
        }

        public double NivJaugeCarburant
        {
            get { return NivJaugeCarburant; }
            set { NivJaugeCarburant = value; }
        }



    }
}
