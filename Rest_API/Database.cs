namespace Rest_API
{
    public class Database
    {
        public List<Animal> Animals;
        public List<Visit> Visits;
        private static Database db;

        private Database()
        {
            Animals = new List<Animal>();
            Visits = new List<Visit>();

            for (int i = 0; i < 10; i++)
            {
                Animal a = new Animal();
                a.Name = "A" + i;
                a.Id = i;
                a.FurColor = "Green";
                a.Weight = i * 50;
                Animals.Add(a);
            }
        }
        public static Database GetDatabase()
        {
            if (db == null)
            {
                db = new Database();
            }
            return db;
        }
    }
}
