using BussinesEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class PacienteDAL
    {
        static cetcruDbContext db = new cetcruDbContext();

        public static List<PacienteRF03> consulta()
        {
            return db.PacientesRF03.ToList();
        }
        public static List<PacienteRF03> consultaPorNombre(string nom)
        {
            return db.PacientesRF03.Where(m => m.Nombre == nom).ToList();
        }

        public static List<PacienteRF03> consultaPorId(int Id)
        {
            return db.PacientesRF03.Where(idpac => idpac.Id == Id).ToList();
        }

        public static bool insertar(PacienteRF03 m)
        {
            db.PacientesRF03.Add(m);
            return db.SaveChanges() > 0;
        }

        //actualizar
        //public static bool actualizar(MedicoRF02 m)
        //{


        //    //db.MedicosRF02.Attach(m);
        //    // db.MedicosRF02.FirstOrDefault(x=> x.Id==m.Id);
        //    //db.Entry(m).State = EntityState.Modified;//actualizacion
        //    var medicoeditar = new MedicoRF02();
        //    medicoeditar = null;
        //    medicoeditar = db.MedicosRF02.FirstOrDefault(x => x.Id == m.Id);
        //    medicoeditar.Nombre = m.Nombre;
        //    medicoeditar.Apellidos = m.Apellidos;
        //    medicoeditar.Area = m.Area;
        //    medicoeditar.Esp_O_Cargo = m.Esp_O_Cargo;
        //    medicoeditar.Cedula_Profesional = m.Cedula_Profesional;


        //    return db.SaveChanges() > 0;




        //}
    }
}
