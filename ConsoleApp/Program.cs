public class Program
{

  // Point d'entrée de l'application => syntaxe standard
  // static => appel en direct sur la classe (ex: Program.Main())
  public static void Main()
  {
    // donner des instructions à mon programme
    // créer une variable compte1 de type CompteBancaire
    // dans compte1 on stocke un objet de type CompteBancaire 
    // opérateur new => créer une instance d'objet
    Client client1 = new Client("Jean", "Dupont", "jean@", "04...");
    Client client2 = new Client("Boris", "N", "boris@", "04...");
    CompteBancaire compte1 = new CompteBancaire(client1, "EUR", 1000);
    CompteBancaire compte2 = new CompteBancaire(client2, "EUR", 1000);
    // manipuler l'objet
    // afficher le solde
    compte1.AfficherSolde();
    // crediter
    compte1.Crediter(500);
    // afficher le solde
    compte1.AfficherSolde();

    // démo toString
    Console.WriteLine("compte1 : " + compte1.ToString());

    // démo equals()
    if (compte1.Equals(compte2)) {
      Console.WriteLine("compte1 et compte2 sont égaux");
    } else {
      Console.WriteLine("compte1 et compte2 ne sont pas égaux");
    }

  }

}