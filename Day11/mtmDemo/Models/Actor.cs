using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mtmDemo.Models
{
    public class Actor
    {
        [Key]
        public int ActorId {get;set;}
        
        [Required]
        public string FirstName {get;set;}
        
        [Required]
        public string LastName {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public List<Cast> ActedIn {get;set;}
    }
}