using DemoObserver.Patterns.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserver.Models
{
    class Acheteur : IObserver
    {
        public string Identifiant { get; private set; }

        public Acheteur(string identifiant)
        {
            Identifiant = identifiant;
        }

        public void Update(ISubject subject)
        {
            if (subject is Produit p)
            {
                Console.WriteLine($"{Identifiant} : le produit {p.Nom} a changé de prix : {p.Prix}");
            }
        }
    }
}
