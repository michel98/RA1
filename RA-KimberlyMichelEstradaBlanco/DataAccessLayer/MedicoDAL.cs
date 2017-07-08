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
            
            
               db.MedicosRF02.Attach(m);
               db.Entry(m).State = EntityState.Modified;//actualizacion
               return db.SaveChanges() > 0;
           


        }
    }
}
     










