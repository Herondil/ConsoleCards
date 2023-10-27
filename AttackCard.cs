using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCards
{
    internal class AttackCard : Card
    {
        protected override void ApplyCardEffect()
        {
            Console.WriteLine("Un effet d'attaque est appliqué");
        }
    }
}
