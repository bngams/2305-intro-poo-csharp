public class Chien : Animal
{
  public Chien(string nom, int age) : base(nom, age)
  {
  }

  public override void SePresenter()
  {
    Console.WriteLine($"Ouaf ! Je suis un chien nommé {Nom} et j'ai {Age} an(s).");
  }
}