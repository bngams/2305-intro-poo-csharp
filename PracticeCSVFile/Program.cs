// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var etudiants = new List<Etudiant>
{
    new Etudiant("Dupont", "Alice", 22),
    new Etudiant("Martin", "Bob", 20),
    new Etudiant("Durand", "Chloe", 23),
};

// ecrire la liste dans un fichier en csv
using (var writer = new StreamWriter("etudiants.csv"))
{
    foreach (var etudiant in etudiants)
    {
        writer.WriteLine($"{etudiant.Nom};{etudiant.Prenom};{etudiant.Age}");
    }
}
Console.WriteLine("OK");
