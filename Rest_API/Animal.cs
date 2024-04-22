using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rest_API
{
    public class Animal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnimalID { get; set; }
        public string AnimalName { get; set; }
        public string AnimalType { get; set; }
        //public int Weight { get; set; }
        public string AnimalColor { get; set; }

    }
}



    //public int AnimalID { get; set; }

    //[StringLength(20)]
    //public string AnimalName { get; set; }

    //[StringLength(20)]
    //public string AnimalType { get; set; }

    //[StringLength(20)]
    //public string AnimalColor { get; set; }

