using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCards
{
    //interface qui sert à rendre une carte améliorable
    internal interface IUpgradable
    {
        //ordonne à la classe qui implémente l'interface d'implémenter cette propriété
        //public int propTest { get; set; }

        //une classe qui implémente l'interface doit fournir une déclaration 
        //de la méthode "Upgrade"
        public void Upgrade()
        {
            Console.WriteLine("La carte est améliorée");
        }
    }
}
