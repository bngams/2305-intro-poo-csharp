public class Program
{
  public static void Main(string[] args)
  {
    Os nonos = new Os(10); // Création d'un os de taille 10
    Niche maison = new Niche("rouge"); // Création d'une niche rouge
    Chien monChien = new Chien("Médor"); // Création d'un chien Médor dans la niche rouge    
    monChien.setNiche(maison); // Médor est dans la niche rouge
    monChien.SeDecrire(); // Médor se décrit
    monChien.Jouer(nonos); // Médor joue avec l'os de taille 10
  }

}
