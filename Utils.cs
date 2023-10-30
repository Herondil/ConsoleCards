using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCards
{
    internal class Utils
    {
        //static est un modificateur qui rend un membre "statique"
        //le membre n'est plus lié à une instance particulière
        //mais à la classe directements
        //proba : une probabilité à deux chiffres après la virgule
        public static bool Win(float proba)
        {
            Random r = new Random();
            float tmp = proba * 100;
            int des = r.Next(0, 100);

            if (des < tmp)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //Type générique ou template
        public static void print<T>(T text)
        {
            Console.WriteLine($"voici le texte : {text}");
        }
    }
}
