using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCards
{
    internal abstract class Foe
    {
        //au niveau de la classe
        public static int NombreEnnemis;

        public int pv { get;  set; }
        public string name { get; protected set; }

        //on impose la définition dans une classe dérivée
        //DONC il est obligatoire d'avoir une classe dérivée
        public abstract void Attack();
    }
}
