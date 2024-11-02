using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T25_LoukaConstant_ExosSupp
{
    internal class Entrainements
    {
        private string _nom;
        private string _prenom;
        private double _longueurParcours;

        public Entrainements(string nom, string prenom, double longueurParcours)
        {
            _nom = nom;
            _prenom = prenom;
            _longueurParcours = longueurParcours;
        }

        public string Name
        {
            get { return _nom; }
        }

        public string Prenom
        {
            get { return _prenom; }
        }

        public double LongueurParcours 
        {
            get { return _longueurParcours; }
            set { _longueurParcours = value; }
        }

    }

}
