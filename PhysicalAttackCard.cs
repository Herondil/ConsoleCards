using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCards
{
    internal class PhysicalAttackCard : AttackCard
    {
        //puissance de la carte
        public int power { get ; private set; }

        const int initialPower = 10;

        public PhysicalAttackCard()
        {
            power = initialPower;
        }   

        protected override void ApplyCardEffect()
        {
            Console.WriteLine("L'effet d'attaque physique est appliqué");
        }

        //surcharge de l'opérateur ++
        //on crée une nouvelle carte avec power +1
        public static PhysicalAttackCard operator ++(PhysicalAttackCard card)
        {
            card.power++;
            return card;
        }

        public static PhysicalAttackCard operator +(PhysicalAttackCard card1, PhysicalAttackCard card2)
        {
            PhysicalAttackCard card = new PhysicalAttackCard();
            card.power = card1.power + card2.power;
            return card;
        }

    }
}
