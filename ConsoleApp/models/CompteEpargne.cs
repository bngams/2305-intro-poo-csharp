using System.Security.Cryptography;

public class CompteEpargne : Compte {

  public CompteEpargne() {
    this.numero = RandomNumberGenerator.GetInt32(100000, 999999).ToString();
  }
}