using System.Collections.Generic;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base (options) { }

        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Professor> Professores { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) 
        { 
            builder.Entity<Professor>().HasData(
                new List<Professor>() {
                    new Professor() {
                        Id = 1,
                        Nome = "Paula"
                    },
                    new Professor() {
                        Id  = 2,
                        Nome = "Vinicius"
                    },
                        new Professor() {
                        Id  = 3,
                        Nome = "Roberto"
                    },
                }
            );

            builder.Entity<Aluno>().HasData(
                new List<Aluno>() {
                    new Aluno() {
                        Id = 1,
                        Nome = "Maria",
                        SobreNome = "José",
                        DataNasc = "20/01/1970",
                        ProfessorId = 1
                    },
                    new Aluno() {
                        Id  = 2,
                        Nome = "Tatiane",
                        SobreNome = "Oliveira",
                        DataNasc = "01/01/1990",
                        ProfessorId = 2
                    },
                        new Aluno() {
                        Id  = 3,
                        Nome = "Rafael",    
                        SobreNome = "Bueno",
                        DataNasc = "10/01/2000",
                        ProfessorId = 3
                    },
                }
            );
        }
    }
}