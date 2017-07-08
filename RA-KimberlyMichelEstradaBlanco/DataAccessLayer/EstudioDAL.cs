using BussinesEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EstudioDAL
    {
        static cetcruDbContext db = new cetcruDbContext();
        public static List<EstudioRF01> consulta()
        {
            return db.EstudiosRF01.ToList();
        }

        public static bool consultaPorNombre(string n)
        {
            return db.EstudiosRF01.Where(e => e.Nombre == n).Count() > 0;
        }

        public static List<EstudioRF01> consultaPorId(int Id)
        {
            return db.EstudiosRF01.Where(idest => idest.Id == Id).ToList();
        }

        public static bool insertar(EstudioRF01 e)
        {
            db.EstudiosRF01.Add(e);
            return db.SaveChanges() > 0;
        }

        //actualizar
        public static bool actualizar(EstudioRF01 e)
        {


            db.EstudiosRF01.Attach(e);
            db.Entry(e).State = EntityState.Modified;//actualizacion
            return db.SaveChanges() > 0;



        }
    }
}
