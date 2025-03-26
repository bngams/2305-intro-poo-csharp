public class Chat : Animal
{
  public Chat(string nom, int age) : base(nom, age)
  {
  }

  public override void SePresenter()
  {
    Console.WriteLine($"Miaou ! Je suis un chat nommé {Nom} et j'ai {Age} an(s).");
  }
}