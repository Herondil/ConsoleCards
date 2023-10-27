using ConsoleCards;

Console.WriteLine("Bievenue dans le jeu de carte !");


List<Card> cards = new List<Card>();

cards.Add(new AttackCard());
cards.Add(new PhysicalAttackCard());


//Pattern ?

//Organisation spécifique du code 

//singleton ?
//-> il y a toujours une seule instance d'une classe donnée

//-> on doit interdire le "new"
//-> La classe va créer elle-même son instance
//-> La classe qui garde une référence vers cette instance unique
//-> la référence à l'instance est un "public static"