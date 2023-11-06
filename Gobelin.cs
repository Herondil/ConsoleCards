using ConsoleCards;

internal class Gobelin : Foe
{

    public Gobelin()
    {
        pv = 10;
        name = "Gobelin";
    }


    public override void Attack()
    {
        Random random = new Random();
        int damage = 4 + random.Next(0, 3);

        Console.WriteLine("Vous perdez "+ damage +" points de vie.");
        Player.Instance.PdV -= damage;
        Console.WriteLine("Vous avez maintenant "+ Player.Instance.PdV+" points de vie");
    }
}