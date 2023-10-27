using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCards
{
    internal class Card
    {



        //property
        public virtual string name {  
            get ;
            private set ;
        }

        
        //Methods
        protected virtual void ApplyCardEffect()
        {
            Console.WriteLine($"L'effet de la carte {name} est appliqué");
        }

    }
}
