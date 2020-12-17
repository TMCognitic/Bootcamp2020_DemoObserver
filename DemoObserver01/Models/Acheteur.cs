using DemoObserver.Patterns.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserver.Models
{
    class Acheteur : Observer
    {
        public string Identifiant { get; private set; }

        public Acheteur(string identifiant)
        {
            Identifiant = identifiant;
        }

        public override void Update(Subject subject)
        {
            if (subject is Produit p)
            {
                Console.WriteLine($"{Identifiant} : le produit {p.Nom} a changé de prix : {p.Prix}");
            }
        }
    }
}
