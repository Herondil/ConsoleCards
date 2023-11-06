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

        public HealingCard()
        {
            power = initialPower;
            name = "Soin";
            description = "Soigne de " + power + " points de vie.";
        }

        public override void ApplyCardEffect()
        {
            Console.WriteLine("L'effet de soin est appliqué ...");
            Console.WriteLine("Vous gagnez "+power+" points de vie !");
            Player.Instance.PdV += power;
        }

        //pas très utile
        public override void ApplyCardEffect(Foe _f)
        {
            Console.WriteLine("Vous gagnez " + power + " points de vie !");
            Player.Instance.PdV += power;
            Console.WriteLine("Vous avez maintenant " + Player.Instance.PdV + " points de vie.");
        }
    }
}
