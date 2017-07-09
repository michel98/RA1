using BussinesEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ServicioDAL
    {
        static cetcruDbContext db = new cetcruDbContext();

        public static List<Servicio> consulta()
        {
            return db.Servicios.ToList();
        }

        public static bool insertar(Servicio s)
        {
            db.Servicios.Add(s);
            return db.SaveChanges() > 0;
        }

        public static bool consultaPorId(int Id)
        {
            return db.Servicios.Where(idser => idser.Id == Id).Count()>0;
        }

        public static List<Servicio> consultaPorEstudio(string estudio)
        {
            return db.Servicios.Where(est => est.Estudio == estudio).ToList();
        }

        public static List<Servicio> consultaPorIdMedCan(int Id)
        {
            return db.Servicios.Where(idmedcan => idmedcan.MedicoCanId == Id).ToList();
        }

        public static List<Servicio> consultaPorIdPac(int Id)
        {
            return db.Servicios.Where(idpac => idpac.PacienteId == Id).ToList();
        }

        public static List<Servicio> consultaPorNopagados(bool pago)
        {
            return db.Servicios.Where(pag => pag.Pagado == pago).ToList();
        }
    }
}
