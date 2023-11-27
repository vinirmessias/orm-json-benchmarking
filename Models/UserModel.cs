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
            optionsBuilder.UseSqlServer("Server=tcp:sql-benckmark-tcc.database.windows.net,1433;Initial Catalog=db-benckmark-tcc;Persist Security Info=False;User ID=vinicius-messias;Password=47xN8hhrSNtSuE2;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }

    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
    public long? Id { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public byte Role { get; set; }

    public DateTime CreationDate { get; set; }
}