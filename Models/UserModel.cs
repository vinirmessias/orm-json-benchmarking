using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace orm_json_benchmarking.Models;

public class UserModel
{
    public class UserContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("[connectionstring]");
        }
    }

    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
    public long? Id { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public byte Role { get; set; }

    public DateTime CreationDate { get; set; }
}