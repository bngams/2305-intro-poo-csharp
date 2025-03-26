public class Question {
  public string Enonce { get; set; }
  public string Reponse { get; set; }
  public int Points { get; set; }

  public Question(string enonce, string reponse, int points) {
    Enonce = enonce;
    Reponse = reponse;
    Points = points;
  }
}