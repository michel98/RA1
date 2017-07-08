using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using BussinesEntities;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Runtime.Remoting.Contexts;

namespace DataAccessLayer
{
    public class MedicoDAL
    {
        //sirve para generar la conexion con el modelo de datos
        static cetcruDbContext db = new cetcruDbContext();

        public static List<MedicoRF02> consulta() {
            return db.MedicosRF02.ToList();
        }
        public static bool consultaPorCedula(string ced)
        {
            return db.MedicosRF02.Where(m => m.Cedula_Profesional == ced).Count() > 0;
        }

        public static List<MedicoRF02> consultaPorId(int Id)
        {
            return db.MedicosRF02.Where(idmed => idmed.Id == Id).ToList();
        }

        public static bool insertar(MedicoRF02 m) {
            db.MedicosRF02.Add(m);
            return db.SaveChanges()>0;
        }

        //actualizar
        public static bool actualizar(MedicoRF02 m) {


            //db.MedicosRF02.Attach(m);
            // db.MedicosRF02.FirstOrDefault(x=> x.Id==m.Id);
            //db.Entry(m).State = EntityState.Modified;//actualizacion
            var medicoeditar = new MedicoRF02();
            medicoeditar = null;
            medicoeditar=db.MedicosRF02.FirstOrDefault(x => x.Id == m.Id);
            medicoeditar.Nombre = m.Nombre;
            medicoeditar.Apellidos = m.Apellidos;
            medicoeditar.Area = m.Area;
            medicoeditar.Esp_O_Cargo = m.Esp_O_Cargo;
            medicoeditar.Cedula_Profesional = m.Cedula_Profesional;


            return db.SaveChanges()>0;
            
           


        }
    }
}
     










