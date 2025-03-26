public class Quiz
{
    public Question[] Questions { get; set; }
    public int Points { get; set; }

    public Quiz(Question[] questions)
    {
        Questions = questions;
        Points = 0;
    }

    public void Jouer()
    {
        foreach (Question question_p in Questions)
        {
            Console.WriteLine(question_p.Enonce);
            string reponse = Console.ReadLine();
            if (reponse == "exit")
            {
                throw new Exception("Exit command received");
            }
            // TODO: ignoreCase
            if (question_p.Reponse == reponse)
            {
                Points += question_p.Points;
            }
        }
    }
}
