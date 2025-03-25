public class Chien : Animal
{
  public Chien(string nom) : base(nom)
  {
  }

  public override void Jouer(string compagnon)
  {
    Console.WriteLine($"Ouaf! Joue avec {compagnon}");
  }


  // methods
  public void Aboyer()
  {
    Console.WriteLine("Ouaf");
  }
}