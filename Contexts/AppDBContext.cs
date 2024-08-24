using Microsoft.EntityFrameworkCore;
using ReserveiAPI.Objects.Models.Entities;
using ReserveiAPI.Contexts.Builders;

namespace ReserveiAPI.Contexts
{
    public class AppDBContext : DbContext
    {
        //Mapeamento Relacional dos Objetos no Banco de Dados
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options){ }

        //conjunto : Usuário

        public DbSet<UserModel> Users { get; set; }

        // Fluent API

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Entidades de Usuário:
            UserBuilder.Build(modelBuilder);
        }
    }
}
