using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCards
{
    //on ne peut pas instancier 
    internal abstract class Card
    {

        //property
        //property abstraite
        // -> les classes dérivées doivent implémenter la property
        public virtual string name {  
            get ;
            protected set ;
        }

        
        //Methods
        protected virtual void ApplyCardEffect()
        {
            Console.WriteLine($"L'effet de la carte {name} est appliqué");
        }

    }
}
