using System;
// Need data annotations because we are working with a Key and validations
using System.ComponentModel.DataAnnotations;

namespace afternoonEFDemo.Models
{
    public class Animal
    {
        // This is our ID inside of MySQL (ex: 1, 2, 3...)
        [Key]
        public int AnimalId {get;set;}
        [Required]
        public string Species {get;set;}

        [Range(0,1000)]
        public int numLegs {get;set;}
        public bool isMammal {get;set;}
        
        // Good practice to have created at and updated at in your models!
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}