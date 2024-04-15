using Microsoft.AspNetCore.Mvc;

namespace Rest_API.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class Animals : ControllerBase
    {
        private Database db1;

        public Animals() {
            db1 = Database.GetDatabase();
        }

        [HttpGet(Name = "GetAnimals")]
        public IEnumerable<Animal> Get()
        {
            return db1.Animals.ToArray();
        }

        [HttpGet("{Id}")]
        public Animal GetAnimalById(int animalId)
        {
            Animal a = null;
            foreach (Animal animal in db1.Animals)
            {
                if (animal.Id.Equals(animalId)) { a = animal; }
            }
            return a;
        }

        [HttpPut(Name = "PutAnimal")]
        public Animal Put(string name)
        {
            Animal a = new Animal();
            a.Name = name;
            db1.Animals.Add(a);
            return a;
        }

        [HttpPost(Name = "ChangeAnimalAtributes")] // gdzie się przyjmuje jakie wartości 
        public Animal Post(string name)
        {
            Animal a = new Animal();
            a.Name = name;
            db1.Animals.Add(a);
            return a;
        }

        [HttpDelete(Name = "DeletAnimal")]
        public Animal Delete(int animalId)
        {
            Animal a = null;
            foreach (Animal animal in db1.Animals)
            {
                if (animal.Id.Equals(animalId)) { 
                    a = animal;
                    db1.Animals.Remove(animal);
                }
            }
            return a;
        }

    }
}
