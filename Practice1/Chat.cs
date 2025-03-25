public class Chat : Animal
{
  public Chat(string nom) : base(nom) {}

  public override void Jouer(string compagnon)
  {
    Console.WriteLine($"Miaou! Joue avec {compagnon}");
  }
}