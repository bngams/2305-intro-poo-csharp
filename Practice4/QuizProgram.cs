public class QuizProgram
{
    public static void Main()
    {
        // Première approche avec des tableaux
        Question[] questions = new Question[]
        {
            new Question("Quelle est la capitale de la France ?", "Paris", 1),
            new Question("Quelle est la capitale de l'Espagne ?", "Madrid", 1),
            new Question("Quelle est la capitale de l'Italie ?", "Rome", 1),
            new Question("Quelle est la capitale de l'Allemagne ?", "Berlin", 1),
            new Question("Quelle est la capitale de la Belgique ?", "Bruxelles", 1),
        };

        // Autre approche avec des listes
        // List<Question> listeQuestions = new List<Question>();
        // listeQuestions.Add(new Question("Quelle est la capitale de la France ?", "Paris", 1));
        // listeQuestions.Add(new Question("Quelle est la capitale de l'Espagne ?", "Madrid", 1));
        // ..

        Quiz quiz = new Quiz(questions);
        try
        {
            quiz.Jouer();
        }
        catch (Exception e)
        {
            if (e.Message == "Exit command received")
            {
                Console.WriteLine("Fin du jeu.");
            }
            else
            {
                Console.WriteLine("Une erreur s'est produite.");
            }
        }
        Console.WriteLine($"Vous avez obtenu {quiz.Points} point(s).");

        // sauvegarder le score dans un fichier
        // demander a l'utilisateur si il veut sauvagarder le score
        Console.WriteLine("Sauvegarder le score? O/N");
        string reponse = Console.ReadLine();
        if (reponse == "O" || reponse == "o")
        {
            // si oui, demander le nom de l'utilisateur
            Console.WriteLine("Entrez votre nom :");
            string nom = Console.ReadLine();
            // sauvegarder le nom et le score dans un fichier
            using (var writer = new StreamWriter("scores.txt"))
            {
                writer.WriteLine($"{nom};{quiz.Points}");
            }
        }
    }
}
