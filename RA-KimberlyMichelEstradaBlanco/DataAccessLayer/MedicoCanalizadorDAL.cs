using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BussinesEntities;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class MedicoCanalizadorDAL
    {
        static cetcruDbContext db = new cetcruDbContext();
        public static List<MedicoCanalizador> consultaPorNombre(string nom)
        {
            return db.MedicosCanalizadores.Where(m => m.Nombre == nom).ToList();
        }
        public static List<MedicoCanalizador> consulta()
        {
            return db.MedicosCanalizadores.ToList();
        }

        public static bool insertar(MedicoCanalizador m)
        {
            db.MedicosCanalizadores.Add(m);
            return db.SaveChanges() > 0;
        }

        public static List<MedicoCanalizador> consultaPorId(int Id)
        {
            return db.MedicosCanalizadores.Where(idmed => idmed.Id == Id).ToList();
        }

        public static bool consultaPorIdBool(int Id)
        {
            return db.MedicosCanalizadores.Where(idmed => idmed.Id == Id).Count()>0;
        }

        public static List<Servicio> consultaPorIdMedCan(int Id)
        {
            return db.Servicios.Where(idmedcan => idmedcan.MedicoCanId == Id).ToList();
        }


    }
}
