using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using BussinesEntities;
using System.Threading.Tasks;

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

        public static bool insertar(MedicoRF02 m) {
            db.MedicosRF02.Add(m);
            return db.SaveChanges()>0;
        }
    }
}
     










