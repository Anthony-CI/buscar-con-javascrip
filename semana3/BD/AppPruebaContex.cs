using Microsoft.EntityFrameworkCore;
using semana3.BD.Configuracion;
using semana3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace semana3.BD
{
    public class AppPruebaContex: DbContext 
    {
        
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Tema> Tema { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Pregunta> Pregunta { get; set; }
        public DbSet<Alternativa> Alternativas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Examen> Examenes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Prueba;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ProductoConfiguracion());
            modelBuilder.ApplyConfiguration(new TemaConfiguracion());
            modelBuilder.ApplyConfiguration(new CategoriaConfiguracion());
            modelBuilder.ApplyConfiguration(new PreguntaConfiguracion());
            modelBuilder.ApplyConfiguration(new AlternativaConfiguracion());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguracion());
            modelBuilder.ApplyConfiguration(new ExamenConfiguracion());

        }
    }
}
