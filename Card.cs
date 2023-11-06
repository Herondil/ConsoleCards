using ConsoleCards;
internal abstract class Card
{

    public string name { get; protected set; }
    public string description { get; protected set; }


    public abstract void ApplyCardEffect();

    public abstract void ApplyCardEffect(Foe _f);
}