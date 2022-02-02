using Microsoft.EntityFrameworkCore;

namespace ApiLojaStore.Context
{
    public class BDContext : DbContext
    {
        private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=lojabd;Trusted_Connection=True;";

        // aqui seta o tipo de banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }


       
    }
}
