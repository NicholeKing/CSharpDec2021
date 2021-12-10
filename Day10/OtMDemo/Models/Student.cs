using System;
using System.ComponentModel.DataAnnotations;

namespace OtMDemo.Models
{
    public class Student
    {
        [Key]
        public int StudentId {get;set;}
        [Required]
        public string Name {get;set;}

        // We need to establish a place for the foreign key
        public int TeacherId {get;set;}
        // We get a whole object to reference
        public Teacher MyTeacher {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}