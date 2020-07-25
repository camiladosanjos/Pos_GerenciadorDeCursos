using Cursos.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cursos.Infra.Data.Config
{
    public class CursosDbContext : DbContext
    {

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Instituicao> Instituicao { get; set; }
        public DbSet<Disciplina> Disciplina { get; set; }
        public CursosDbContext()
        {

        }
        public CursosDbContext(DbContextOptions<CursosDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\MSSQLLocalDB;" +
                "Database=Cursos;MultipleActiveResultSets=true;" +
                "Trusted_Connection=true;";

            //optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>()
                .HasOne(p => p.Departamento)
                .WithMany(p => p.Cursos)
                .HasForeignKey(p => p.DepartamentoId);

            modelBuilder.Entity<Departamento>()
                .HasOne(p => p.Instituicao)
                .WithMany(p => p.Departamentos)
                .HasForeignKey(p => p.InstituicaoId);

            modelBuilder.Entity<Instituicao>()                        
                 .HasOne(e => e.Endereco)         
                 .WithOne(ca => ca.Instituicao)                       
                 .HasForeignKey<Endereco>(ca => ca.InstituicaoId);

            modelBuilder.Entity<DetalhamentoCurso>()
                .HasKey(dp => new { dp.DisciplinaCursoId, dp.CursoDisciplinaId });

            modelBuilder.Entity<DetalhamentoCurso>()
               .HasOne(dp => dp.DisciplinaCurso)
               .WithMany(curso => curso.Cursos)
               .HasForeignKey(dp => dp.DisciplinaCursoId);

            modelBuilder.Entity<DetalhamentoCurso>()
               .HasOne<Curso>(dp => dp.CursoDisciplina)
               .WithMany(curso => curso.Disciplina)
               .HasForeignKey(dp => dp.CursoDisciplina);
        }
    }
}
