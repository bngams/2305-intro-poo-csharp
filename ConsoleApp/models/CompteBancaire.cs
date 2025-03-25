using System.Security.Cryptography;

public class CompteBancaire 
{

  // <portee> <type> <nom>;
  private string numero { get; }
  private Client titulaire { get; }
  private string devise { get; }
  private double solde; // double = type de nombre à virgule

  // constructeur
  public CompteBancaire(Client titulaire, string devise, double solde)
  {
    // this => fait référence à l'objet courant (instance en cours)
    this.titulaire = titulaire;
    this.devise = devise;
    this.solde = solde;
    // initialisation du numéro de compte
    this.numero = RandomNumberGenerator.GetInt32(100000, 999999).ToString();
  }

  public void Crediter(double montant)
  {
    solde += montant; // solde = solde + montant
  }

  public void Debiter(double montant)
  {
    solde -= montant; // solde = solde - montant
  }

  public void AfficherSolde()
  {
    Console.WriteLine(this.ToString());
  }

  // redéfinition de la méthode ToString 
  public override string ToString()
  {
    return "Le solde du compte de " + this.titulaire.ToString() + " est de " + this.solde + " " + this.devise;
  }

  // redéfinition de la méthode Equals => respecter la signature de la méthode
  // ? => paramètre facultatif => autorise la valeur null
  public override bool Equals(object? obj)
  {
    // vérifier si obj est null
    if (obj == null) return false;
    // vérifier si obj est de type CompteBancaire
    if (obj.GetType() != this.GetType()) return false;

    // traduire obj en CompteBancaire => cast
    CompteBancaire cb = (CompteBancaire)obj;

    return this.numero == cb.numero;
  }

}
