using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesEntities
{
    public class MedicosDbContext:DbContext
    {
        public MedicosDbContext()
            :base("MedicosDbContext")//buscar cadena de conexion
        {

        }
        //adonet
        public DbSet<MedicoRF02> MedicosRF02 { get; set; }
        public DbSet<EstudioRF01> EstudiosRF01 { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {   //quita el plural del nombre de las tablas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}

