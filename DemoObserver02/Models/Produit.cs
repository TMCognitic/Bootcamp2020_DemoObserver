using DemoObserver.Patterns.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserver.Models
{
    class Produit : Subject
    {
        private double _prix;
        public string Nom { get; private set; }

        public double Prix
        {
            get
            {
                return _prix;
            }

            set
            {
                if (_prix != value)
                {
                    _prix = value;
                    Notify();
                }
            }
        }

        public Produit(string nom)
        {
            Nom = nom;
        }
    }
}
