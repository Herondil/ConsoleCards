using ConsoleCards;

Console.WriteLine("Bievenue dans le jeu de carte !");

List<Card> cards = new List<Card>();

PhysicalAttackCard m1 = new PhysicalAttackCard();
PhysicalAttackCard m2 = new PhysicalAttackCard();

Console.WriteLine(m1.power);

m1++;

Console.WriteLine(m1.power);

PhysicalAttackCard m3 = m1 + m2;

Console.WriteLine(m3.power);