using DemoObserver.Models;
using System;

namespace DemoObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            Produit ps5 = new Produit("Console Playstation 5");
            Produit macBookPro = new Produit("Apple Mac Book Pro");

            Acheteur dominique = new Acheteur("Dominique");
            Acheteur thierry = new Acheteur("Thierry");
            Acheteur rachid = new Acheteur("Rachid");

            ps5.Handler += dominique.Annonce;
            ps5.Handler += thierry.Annonce;

            macBookPro.Handler += rachid.Annonce;            

            ps5.Prix = 499;
            macBookPro.Prix = 2_879.99;
        }
    }
}
