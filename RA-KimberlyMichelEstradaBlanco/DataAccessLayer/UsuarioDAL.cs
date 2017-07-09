using BussinesEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UsuarioDAL
    {
        static cetcruDbContext db = new cetcruDbContext();
        public static bool insertar(Usuario u)
        {
            db.Usuarios.Add(u);
            return db.SaveChanges() > 0;
        }

        public static List<Usuario> consulta() {
            return db.Usuarios.ToList();
        }
    }
}
