using Microsoft.EntityFrameworkCore;
using Pontual.Models;

namespace Pontual.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<CadastroModel> Tabela_Cadastro { get; set; }
        public DbSet<ContatoModel> Tabela_Contato { get; set; }
        public DbSet<EnderecoModel> Tabela_Endereco { get; set; }
        public DbSet<GraficoModel> Tabela_Grafico { get; set; }
        public DbSet<LoginModel> Tabela_Login { get; set; }
        public DbSet<PerfilModel> Tabela_Perfil { get; set; }
        public DbSet<RegistroPontoModel> Tabela_RegistroPonto { get; set; }
        public DbSet<UsuarioModel> Tabela_Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RegistroPontoModel>()
                .HasOne<UsuarioModel>()
                .WithMany()
                .HasForeignKey(rp => rp.IdUsuario);
        }
    }
}