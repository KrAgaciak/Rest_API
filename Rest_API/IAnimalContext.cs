using System.Data.Entity;

namespace Rest_API
{
    public interface IAnimalContext
    {
        public DbSet<Animal> Animals { get; set; }

        int SaveChanges();
    }
}
