public class Animal
{
  public string Nom { get; set; }
  public int Age { get; set; }

  public Animal(string nom)
  {
    Nom = nom;
  }

  // virtual method => can be overriden by derived classes
  public virtual void Jouer(string compagnon)
  {
    // raccourci $"string" => permet d'injecter des variables 
    // dans des chaines de caractères
    Console.WriteLine($"Joue avec {compagnon}");
  }
}