using System;
using System.ComponentModel.DataAnnotations;

namespace efDemo.Models
{
    public class Music
    {
        [Key]
        public int MusicId {get;set;}
        [Required]
        public string Title {get;set;}
        [Required]
        public string Artist {get;set;}
        [Required]
        public string Genre {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}