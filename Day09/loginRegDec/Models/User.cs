using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace loginRegDec.Models
{
    public class User
    {
        // Never forget your key!!
        [Key]
        public int UserId {get;set;}

        [Required]
        public string username {get;set;}

        [Required]
        [EmailAddress]
        // email pattern A-Z0-9@A-Z0-9.com/net(A-Z)
        public string email {get;set;}

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string password {get;set;}

        // Don't forget created at and updated at
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        // These are all the things I want to be aware of but not save to my database
        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("password")]
        public string confirm {get;set;}
    }
}