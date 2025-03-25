// APPROCHE syntaxe moderne C#
/* public class Niche
{
  public string Couleur { get; set; }

  public Niche(string couleur)
  {
    this.couleur = couleur;
  }
} */

// APPROCHE syntaxe classique objet
public class Niche {
  private string couleur;

  public Niche(string couleur) {
    this.couleur = couleur;
  }

  public string getCouleur() {
      return this.couleur;
  }

  public void setCouleur(string couleur) {
    this.couleur = couleur;
  }
}