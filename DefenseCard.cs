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

        protected override void ApplyCardEffect()
        {
            throw new NotImplementedException();
        }
    }
}
