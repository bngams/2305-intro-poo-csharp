public class Chien {
  public string nom;
  public Niche niche;

  public Tatouage tatouage;

  public Chien(string nom) {
    this.nom = nom;
    this.tatouage = new Tatouage("123");
  }

  public string getNom() {
    return this.nom;
  }

  public void setNiche(Niche n) {
    this.niche = n;
  }

  public void Jouer(Os os) {
    Console.WriteLine("Joue avec l'os de taille " + os.Taille);
  }

  public void SeDecrire() {
    Console.WriteLine("Je suis " + this.nom 
      + ", mon tatouage est " + this.tatouage.Numero 
      + " et je suis dans la niche " + this.niche.getCouleur());
  }
}