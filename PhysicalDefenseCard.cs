using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCards
{
    internal class PhysicalDefenseCard : DefenseCard
    {
        int power;
        const int initialPower = 5;

        PhysicalDefenseCard()
        {
            power = initialPower;
        }

        protected override void ApplyCardEffect()
        {
            Console.WriteLine("L'effet de defense physique est appliqué");
        }
    }
}
