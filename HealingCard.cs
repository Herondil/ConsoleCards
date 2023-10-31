using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//on aimerait un système qui permette à une carte de s'améliorer

namespace ConsoleCards
{
    internal class HealingCard : Card
    {
        int power;
        const int initialPower = 5;

        HealingCard()
        {
            power = initialPower;
        }

        protected override void ApplyCardEffect()
        {
            Console.WriteLine("L'effet de soin est appliqué");
        }
    }
}
