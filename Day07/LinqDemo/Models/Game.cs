using System;

namespace LinqDemo.Models
{
    public class Game
    {
        public string Title {get;set;}
        public string Genre {get;set;}
        public double Price {get;set;}
        public string Rating {get;set;}
        public string Platform {get;set;}
        public int minNumPlayers {get;set;} = 1;
        public int maxNumPlayers {get;set;}
    }
}