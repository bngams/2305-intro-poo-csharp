public class Program {

  public static void Main() {
    // Création du tableau pour stocker 5 objets de type Animal
    Animal[] animaux = new Animal[5];

    // Remplissage du tableau avec des objets Chien et Chat
    animaux[0] = new Chat("Felix", 3);
    animaux[1] = new Chien("Rex", 5);
    animaux[2] = new Chat("Mimi", 2);
    animaux[3] = new Chien("Buddy", 4);
    animaux[4] = new Chat("Luna", 1);

    // Marquer quelques animaux comme adoptés
    animaux[0].EstAdopte = true;
    animaux[3].EstAdopte = true;

    // Affichage des détails des animaux
    foreach (Animal animal in animaux)
    {
      Console.WriteLine(animal.SePresenter());
      if(animal.EstAdopte)
      {
        Console.WriteLine("Statut : adopté");
      }
      else
      {
        Console.WriteLine("Statut : en attente");
      }
      // Ou en utilisant l'opérateur ternaire 
      // Console.WriteLine($"Statut : {(animal.EstAdopte ? "adopté" : "en attente")}");
    }

    // Affichage des animaux non adoptés
    foreach (Animal animal in animaux)
    {
      if (!animal.EstAdopte)
      {
        Console.WriteLine($"➤ {animal.Nom} est disponible à l’adoption.");
      }
    }

    // Création d'une collection "dynamique" 
    // pour stocker X objets de type Animal
    List<Animal> listeAnimaux = new List<Animal>();
    listeAnimaux.Add(new Chat("Garfield", 6));
    listeAnimaux.Add(new Chien("Rex", 6));
    // parcourir la liste et afficher les détails des animaux
    foreach (Animal animal in listeAnimaux)
    {
      Console.WriteLine(animal.SePresenter());
    }
    
  }
}