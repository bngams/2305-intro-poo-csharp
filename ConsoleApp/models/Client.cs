public class Client
{

  // Propriété pour stocker le nom du client
  public string nom { get; set; }

  // Propriété pour stocker le prénom du client
  public string prenom { get; set; }

  // Propriété pour stocker l'email du client
  public string email { get; set; }

  // Propriété pour stocker le numéro de téléphone du client
  public string telephone { get; set; }

  // Constructeur de la classe Client
  // Ce constructeur permet d'initialiser un objet Client avec les valeurs fournies pour le nom, le prénom, l'email et le téléphone.
  public Client(string nom, string prenom, string email, string telephone)
  {
    // Initialisation des propriétés de l'objet avec les valeurs passées en paramètres
    this.nom = nom; // Le mot-clé 'this' fait référence à la propriété de l'objet actuel
    this.prenom = prenom;
    this.email = email;
    this.telephone = telephone;
  }

  // Redéfinition de la méthode ToString
  public override string ToString()
  {
    // Retourne une chaîne de caractères représentant l'objet Client
    return this.prenom + " " + this.nom;
  }
}
