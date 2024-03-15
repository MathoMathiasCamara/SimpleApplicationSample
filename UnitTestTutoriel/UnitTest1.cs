namespace UnitTestTutoriel
{
    public class Tests
    {
        [Test]
        public void CreateEtudiant()
        {
            //arragement 
            string prenom = "Moussa";
            string nom = "Camara";
            DateTime age = DateTime.Now;

            //action
            var etudiant = new Etudiant(prenom, nom, age);

            Assert.True(etudiant.Prenom == prenom);
            Assert.True(etudiant.Nom == nom);
            Assert.True(etudiant.DateNaissance == age);
        }


        [Test]
        public void InsertEtudiant()
        {
            //arragement 
            //var database = new Database();
            var database = new Table<Etudiant>();

            var etudiant = new Etudiant("moussa","keita",DateTime.Now);

            // action
            database.Ajouter(etudiant);

            //
            //Assert.True(Database.Students.Contains(etudiant));
            Assert.True(Table<Etudiant>.Students.Contains(etudiant));
        }

        [Test]
        public void DeleteEtudiant()
        {
            //arragement 
            //var database = new Database();
            var database = new Table<Etudiant>();
            var etudiant = new Etudiant("moussa", "keita", DateTime.Now);

            // action
            database.Ajouter(etudiant);

            database.Supprimer(etudiant);

            //
            //Assert.True(Database.Students.Contains(etudiant));
            Assert.True(Table<Etudiant>.Students.Contains(etudiant));
        }


        [Test]
        public void CreerProfesseur()
        {
            //arragement 
            string nom = "Moussa Keita";

            //action
            var etudiant = new Professeur(nom);

            Assert.True(etudiant.Nom == nom);
        }

        [Test]
        public void AttribuerEtudiantAuProfesseur()
        {
            //arragement 
            string nom = "Moussa Keita";
            var prof = new Professeur(nom);
            var etudiant = new Etudiant("Alex", "Keita", DateTime.Now);

            //action
            prof.AjouterEtudiant(etudiant);

            Assert.True(prof.Etudiants.Contains(etudiant));
        }

        [Test]
        public void TestTestings()
        {
            //arragement 
            var tableaux = new Table<Professeur>();

            string nom = "Moussa Keita";
            var prof = new Professeur(nom);
            var etudiant1 = new Etudiant("Alex", "Keita1", DateTime.Now);
            var etudiant2 = new Etudiant("Alex1", "Keita2", DateTime.Now);
            var etudiant3 = new Etudiant("Alex2", "Keita3", DateTime.Now);
            var etudiant4 = new Etudiant("Alex3", "Keita4", DateTime.Now);

            tableaux.Ajouter(prof);

            prof.AjouterEtudiant(etudiant1);
            prof.AjouterEtudiant(etudiant2);
            prof.AjouterEtudiant(etudiant3);
            prof.AjouterEtudiant(etudiant4);
        }
    }
}