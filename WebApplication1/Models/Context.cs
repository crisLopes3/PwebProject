using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Context : DbContext
    {
        public Context() : base("name=DefaultConnection")
        {
            Database.SetInitializer<Context>(new DropCreateDatabaseIfModelChanges<Context>());
        }


        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Docente> Docentes { get; set; }
        public DbSet<Proposta> Propostas { get; set; }
        public DbSet<Comissao> Comissoes { get; set; }


        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    // Configure Student & StudentAddress entity
        //    modelBuilder.Entity<Docente>()
        //                .HasOptional(s => s.Comissao) // Mark Address property optional in Student entity
        //                .WithRequired(ad => ad.Docentes); // mark Student property as required in StudentAddress entity. Cannot save StudentAddress without Student
        //}
    }
}