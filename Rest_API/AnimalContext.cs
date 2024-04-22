using System.Data.Entity;

namespace Rest_API
{

    public class AnimalContext : DbContext, IAnimalContext
    {
        public DbSet<Animal> Animals { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public AnimalContext() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=APBD_Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;")
        {
        }
    }
}
