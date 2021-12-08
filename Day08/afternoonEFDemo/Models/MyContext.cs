// We are using Entity Framework for this, so we need to bring it in
using Microsoft.EntityFrameworkCore;
// Make sure you are using YOUR namespace
namespace afternoonEFDemo.Models
{ 
    // the MyContext class representing a session with our MySQL 
    // database allowing us to query for or save data
    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { }
        // the "Animals" table name will come from the DbSet variable name
        // This will equate to the table name you will see in MySQL Workbench
        public DbSet<Animal> Animals { get; set; }
        //          Model     Table
    }
}
