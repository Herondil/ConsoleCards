using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCards
{
    internal class MagicAttackCard : AttackCard,IUpgradable
    {
        int power;
        const int initialPower = 5;

        public MagicAttackCard()
        {
            power = initialPower;
        }

        protected override void ApplyCardEffect()
        {
            Console.WriteLine("L'effet d'attaque magique est appliqué");
        }

        public void Upgrade()
        {
            //le pouvoir de la carte augmente de 5
            power += 5;
        }
    }
}
