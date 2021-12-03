using System;
using System.ComponentModel.DataAnnotations;

namespace mvcDemo.Models
{
    public class Pet
    {
        [Display(Name = "Pet Name")]
        [Required(ErrorMessage = "Pet has to have a name!")]
        public string petName {get;set;}

        [Required(ErrorMessage = "Pet must have a type!")]
        [MinLength(2,ErrorMessage = "Pet Type must contain at least 2 characters!")]
        public string petType {get;set;}

        [Required(ErrorMessage = "Pet must have an age!")]
        [Range(0,25,ErrorMessage = "Pet must be between 0 and 25 years old!")]
        public int petAge {get;set;}
    }
}