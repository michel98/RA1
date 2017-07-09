using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BussinesEntities;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class PacienteBLL
    {
        public static List<PacienteRF03> visualizar()
        {
            return DataAccessLayer.PacienteDAL.consulta();
        }

        public static List<PacienteRF03> busquedaNombre(string nom)
        {
            return DataAccessLayer.PacienteDAL.consultaPorNombre(nom);


        }
        public static List<PacienteRF03> busquedaId(int idpac)
        {
            return DataAccessLayer.PacienteDAL.consultaPorId(idpac).ToList();


        }
    }
}
