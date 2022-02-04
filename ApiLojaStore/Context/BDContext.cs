using ApiLojaStore.Model;
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

        // adiciona tabela ao banco de dados, a partir do modelo criado
        public DbSet<User> Users { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Entrada> Entradas { get; set; }

        public DbSet<Venda> Vendas { get; set; }


    }
}
