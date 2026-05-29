using bibliotec.Models;
using Microsoft.EntityFrameworkCore; // Importa o EF Core (DbContext, DbSet, ModelBuilder, etc.)

namespace bibliotec.Contexts
{
    // DbContext é a classe central do EF Core — representa a sessão com o banco de dados
    // BbDbContext é a implementação personalizada do projeto (Bb = Biblioteca)
    public class BbDbContext : DbContext
    {
        // Construtor que recebe as opções de configuração (string de conexão, provider, etc.)
        // Essas opções são injetadas pelo Program.cs via AddDbContext<BbDbContext>(...)
        public BbDbContext(DbContextOptions<BbDbContext> options)
        : base(options) {} // Repassa as opções para a classe base (DbContext)

        // ===== DbSets — cada um representa uma tabela no banco de dados =====
        // O EF Core usa essas propriedades para gerar as tabelas e realizar queries

        public DbSet<Usuario> Usuario { get; set; } = null!;

        // ⚠️ ERRO: Os DbSets abaixo estão todos tipados como DbSet<Usuario>
        //    mas deveriam usar seus próprios Models. Isso vai causar erros graves
        //    ou comportamento inesperado no banco. Corrija conforme abaixo:

        public DbSet<Categoria> Categoria { get; set; } = null!;
        //  ✅ Correto: public DbSet<Categoria> Categoria { get; set; } = null!;

        public DbSet<Livro> Livro { get; set; } = null!;
        //  ✅ Correto: public DbSet<Livro> Livro { get; set; } = null!;

        public DbSet<LivroCategoria> LivroCategoria { get; set; } = null!;
        //  ✅ Correto: public DbSet<LivroCategoria> LivroCategoria { get; set; } = null!;

        public DbSet<Reserva> Reserva { get; set; } = null!;
        //  ✅ Correto: public DbSet<Reserva> Reserva { get; set; } = null!;

        // Método chamado pelo EF Core na criação do modelo — usado para configurações
        // que não cabem em atributos (como chaves compostas, índices, relacionamentos, etc.)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configura a chave primária composta da tabela LivroCategoria
            // Como é uma tabela intermediária (N:N entre Livro e Categoria),
            // ela não tem um Id próprio — a chave é a combinação de LivroId + CategoriaId
            modelBuilder.Entity<LivroCategoria>()
                .HasKey(lc => new { lc.LivroId, lc.CategoriaId });
        }
    }
}