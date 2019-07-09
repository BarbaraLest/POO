using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Modelo;


namespace Persistencia
{
    public class EFContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Pet> Pets { get; set; }

        public DbSet<Veterinario> Veterinarios { get; set; }

        public DbSet<Consulta> Consultas { get; set; }

        public DbSet<Exame> Exames { get; set; }

        public DbSet<Receita> Receitas { get; set; }

     

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=OO_EFCore;Trusted_Connection=True;");
        }


        
    }
}

 