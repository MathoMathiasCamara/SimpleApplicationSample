namespace UnitTestTutoriel
{
    public class Professeur
    {
        public Professeur(string nom)
        {
            Nom = nom;
        }

        public string Nom { get; set; }
        public List<Etudiant> Etudiants { get; set; } = new List<Etudiant>(); 
        public void AjouterEtudiant(Etudiant etudiant)
        {
            Etudiants.Add(etudiant);
        }
    }
}
