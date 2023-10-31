﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCards
{
    internal class PhysicalAttackCard : AttackCard
    {
        //puissance de la carte
        int power;
        const int initialPower = 10;

        public PhysicalAttackCard()
        {
            power = initialPower;
        }   

        protected override void ApplyCardEffect()
        {
            Console.WriteLine("L'effet d'attaque physique est appliqué");
        }
    }
}
