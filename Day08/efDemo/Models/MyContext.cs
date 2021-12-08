using Microsoft.EntityFrameworkCore;
namespace efDemo.Models
{ 
    // the MyContext class representing a session with our MySQL 
    // database allowing us to query for or save data
    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { }
        // the "Music" table name will come from the DbSet variable name
        public DbSet<Music> Music { get; set; }
    }
}
