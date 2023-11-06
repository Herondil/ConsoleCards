using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleCards
{
    internal class DefenseCard : Card
    {
        public DefenseCard()
        {
            name = "Carte de défense";
        }

        public override void ApplyCardEffect()
        {
            throw new NotImplementedException();
        }

        public override void ApplyCardEffect(Foe _f)
        {
            throw new NotImplementedException();
        }
    }
}
