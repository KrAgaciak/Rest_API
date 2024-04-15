using Microsoft.AspNetCore.Mvc;

namespace Rest_API.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class Vistis : ControllerBase
    {
        private Database db1;

        public Vistis()
        {
            db1 = Database.GetDatabase();
        }

        [HttpGet(Name = "GetVisits")]
        public IEnumerable<Visit> Get()
        {
            return db1.Visits.ToArray();
        }

        [HttpPut(Name = "PutVisit")]
        public Visit Put(DateTime dateOfVisit, int animalId
                        , string visitDescription, int visitPrice)
        {
            Animal a = null;
            foreach (Animal animal in db1.Animals) 
            {
                if (animal.Id.Equals(animalId)) { a = animal;}
            }
            Visit v = new Visit();
            v.VisitDate = dateOfVisit;
            v.Animal = a;
            v.VisitDecription = visitDescription;
            v.VisitPrice = visitPrice;

            db1.Visits.Add(v);
            return v;
        }
    }
}
