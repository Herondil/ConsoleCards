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
            name = "Attaque Magique";
            description = "Attaque l'ennemi avec une puissance de " + power + ".";
        }

        public override void ApplyCardEffect(Foe _f)
        {
            Console.WriteLine("Vous lancez une attaque magique sur "+_f.name+" ...");
            Console.WriteLine( _f.name + " perd "+power+" points de vie.");
            _f.pv -= power;
        }

        public void Upgrade()
        {
            //le pouvoir de la carte augmente de 5
            power += 5;
        }


        public override void ApplyCardEffect()
        {
            throw new NotImplementedException();
        }
    }
}
