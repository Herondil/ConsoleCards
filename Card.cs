internal abstract class Card
{

    public string name { get; protected set; }

    protected abstract void ApplyCardEffect();
}