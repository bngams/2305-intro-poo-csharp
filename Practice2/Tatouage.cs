public class Tatouage {
  public string Numero { get; }
  public string Date { get; }

  public Tatouage(string numero) {
    Numero = numero;
    Date = DateTime.Now.ToString();
  }

}