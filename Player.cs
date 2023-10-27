using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 *  SINGLETON
 * 
 */
namespace ConsoleCards
{
    internal sealed class Player
    {

        //property pour le nom
        public string name { get; private set; }
       
        //field public pour les cartes
        public List<Card> cards;

        //initialisation ?
        //avec une minuscule, en privé par sécurité
        private static Player instance = null;


        //une référence vers l'instance
        //avec une majuscule
        public static Player Instance {

            get { 
                if(instance == null) //pas fiable ?
                {
                    instance = new Player("Player1");
                    Console.WriteLine("instance crée");
                }
                return instance; 
            } 
        }

        //constructeur
         Player(string _name)
        {
            name = _name;
            cards = new List<Card>(); // initialisation de la main de cartes, main vide
        }
    }
}
