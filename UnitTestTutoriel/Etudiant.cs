
namespace UnitTestTutoriel
{
    public class Etudiant
    {
        public string Prenom;
        public string Nom;
        public DateTime DateNaissance;

        public Etudiant(string v1, string v2, DateTime now)
        {
            this.Prenom = v1;
            this.Nom = v2;
            this.DateNaissance = now;
        }
    }
}