// See https://aka.ms/new-console-template for more information
using UnitTestTutoriel;

Console.WriteLine("Hello, Bienvenue!");
Console.WriteLine();
Console.WriteLine("Entrez le nom du professeur: ");

var profName = Console.ReadLine();
var prof = new Professeur(profName);

//ajouter 2 etudiants
int nombreEtudiant = 0;
Console.WriteLine("Entrez le nombre d'etudiant: ");
var number = Console.ReadLine();
nombreEtudiant = Convert.ToInt32(number);

for (int i = 0; i < nombreEtudiant; i++)
{
    Console.WriteLine("Entrez les infos de l'etudiant:");
    Console.WriteLine("Prenoms de l'etudiant:");
    var prenoms = Console.ReadLine();
    Console.WriteLine("Nom de l'etudiant:");
    var nom = Console.ReadLine();
    var etudiant = new Etudiant(prenoms, nom, DateTime.Now);
    prof.AjouterEtudiant(etudiant);
}

Console.WriteLine($"le Professeur : {prof.Nom} ");
Console.WriteLine($"A {prof.Etudiants.Count} etudiant(s) : ");
int compteur = 1;

foreach (var item in prof.Etudiants)
{
    Console.WriteLine($"Etudiant Numero :{compteur} ");
    Console.WriteLine($"Prenoms: {item.Prenom}");
    Console.WriteLine($"Nom: {item.Nom}");
    Console.WriteLine();
    compteur++;
}
Console.ReadKey();