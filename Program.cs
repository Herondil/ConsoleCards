using ConsoleCards;

Console.WriteLine("Bievenue dans le jeu de carte !");
Console.WriteLine("Vous êtes un guerrier, et, sur votre route se dresse un gobelin ...");
Console.WriteLine("C'est l'heure du combat !");

//Player est une singleton, donc on il s'auto créera

//Créer un ennemi
Gobelin g = new Gobelin();

bool running = true; //condition pour continuer ou non le jeu
string input = null; //ce que le joueur tapera pour Console.ReadLine();

while (running)
{ 
    render();
    update();
}

//ce qu'on affiche à l'écran au début
void render()
{
    Console.Clear();
    Console.WriteLine(g.name+" a "+g.pv+" points de vie.");
    Console.WriteLine("Vous avez " + Player.Instance.PdV + " points de vie.");
    Console.WriteLine("-> "+g.name+" va attaquer au prochain tour !");
    //afficher les cartes du joueur
    Console.WriteLine("Voici vos cartes :");
    Player.Instance.AfficherCartes();
    Console.WriteLine("Quelle carte voulez-vous jouer ? Entrez son numéro.");
    input = Console.ReadLine();
    Console.Clear();
}

//on met à jour l'état du jeu, le joueur choisit sa carte puis ensuite l'ennemi
void update()
{
    if(input != null)
    {
        //Tour du joueur
        Console.WriteLine("Vous jouez la carte "+input+", " + Player.Instance.cards[Int32.Parse(input) - 1].name);
        Player.Instance.cards[Int32.Parse(input) - 1].ApplyCardEffect(g);
        Player.Instance.cards.RemoveAt(Int32.Parse(input) - 1);
        if(g.pv <= 0)
        {
            Console.WriteLine("Vous avez anéanti " + g.name + " !");
            Console.WriteLine("Bravo !_!_!_!_!_!_!");
            running = false;
        }

        //Tour de l'ennemi
        Console.WriteLine(g.name+" vous attaque  !");
        g.Attack();
        if (Player.Instance.PdV <= 0)
        {
            Console.WriteLine(g.name + " vous a vaincu ...");
            Console.WriteLine(" --- Défaite --");
            running = false;
        }
    }

    Console.WriteLine("Appuyer sur entrée pour lancer le tour suivant ...");
    Console.ReadLine();
}