using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCards
{
    internal class MagicDefenseCard : DefenseCard
    {
        int power;
        const int initialPower = 5;

        MagicDefenseCard()
        {
            power = initialPower;
        }

        public override void ApplyCardEffect()
        {
            Console.WriteLine("L'effet de defense magique est appliqué");
        }
    }
}
