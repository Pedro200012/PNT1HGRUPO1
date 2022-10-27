using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Concesionaria
{
    
        public class ConcesionariaContext : DbContext
        {
            public DbSet<Persona> Personas { get; set; }    //equivale a una lista de Personas, pero mapeado a la tabla de la bdd
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=TITO-PC\SQLEXPRESS;Database=ConcesionariaDBCF;Trusted_Connection=True;");
            }
        }

    
}

