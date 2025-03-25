class Program
{
  static void Main(string[] args)
  {
    Chien monChien = new Chien("Rex");
    Chat monChat = new Chat("Mephisto");
    monChien.Aboyer();
    monChien.Jouer("Boris");
    monChat.Jouer("Boris");
  }
}