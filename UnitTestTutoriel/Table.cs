namespace UnitTestTutoriel
{
    public class Table<TType> where TType : class
    {
        public Table()
        {
        }
        public void Ajouter(TType item)
        {
            Students.Add(item);
        }
        public void Supprimer(TType item)
        {
            Students.Remove(item);
        }
        public static List<TType> Students { get; set; } = new List<TType>();
    }
}
