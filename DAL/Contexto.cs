using P2_AP1_Ismarlin2018_0846.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_AP1_Ismarlin2018_0846.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Proyectos> Proyectos { get; set; }
        public DbSet<TipoTareas> TipoTareas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(@"Data Source = Data/Parcial.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TipoTareas>().HasData(
            new TipoTareas { TipoId = 1, TipoTarea = "Analisis", FechaIngreso = DateTime.Now.AddDays(1) },
            new TipoTareas { TipoId = 2, TipoTarea = "Diseño", FechaIngreso = DateTime.Now.AddDays(1) },
            new TipoTareas { TipoId = 3, TipoTarea = "Programacion", FechaIngreso = DateTime.Now.AddDays(1) },
            new TipoTareas { TipoId = 4, TipoTarea = "Prueba", FechaIngreso = DateTime.Now.AddDays(1) });
        }
    }
}
