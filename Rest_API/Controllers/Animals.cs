using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace Rest_API.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class Animals: ControllerBase
    {
        IAnimalContext context;

        public Animals(IAnimalContext context) {
            this.context = context;
        }

        [HttpGet(Name = "GetAnimals")]
        public ActionResult<IEnumerable<Animal>> Get()
        {
            
            var sortedAnimals = context.Animals.OrderBy(a => a.AnimalName).ToList();
            return Ok(sortedAnimals);
            
        }

        [HttpGet("{Id}")]
        public ActionResult GetAnimalById(int animalId)
        {
            Animal a1 = null;
                a1 = context.Animals.Where(a => a.AnimalID == animalId).FirstOrDefault(); 
            if (a1 == null)
            {
                return NotFound();
            }

            return Ok(a1);
        }

        [HttpPut(Name = "PutAnimal")]
        public Animal Put(string name)
        {
            Animal a = new Animal();
            a.AnimalName = name;
            
                context.Animals.Add(a);
                context.SaveChanges();
            
            return a;
        }

        [HttpPost(Name = "ChangeAnimalAtributes")]
        public ActionResult Post(int id, string name, string type, string color)
        {
            Animal animal = null;

                animal = context.Animals.FirstOrDefault(a => a.AnimalID == id);

                if (animal != null)
                {
                    animal.AnimalName = name;
                    animal.AnimalColor = color;
                    animal.AnimalType = type;

                    context.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            
            return Ok(animal);
        }

        [HttpDelete(Name = "DeletAnimal")]
        public ActionResult Delete(int animalId)
        {
            Animal animal = null;
            
            
                animal = context.Animals.FirstOrDefault(a => a.AnimalID == animalId);
                if (animal != null)
                {
                    context.Animals.Remove(animal);
                    context.SaveChanges();
                }
                else
                {
                    return NotFound();
                }

            
            return Ok(animal);
        }

    }
}
