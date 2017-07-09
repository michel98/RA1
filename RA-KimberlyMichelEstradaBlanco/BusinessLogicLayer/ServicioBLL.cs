using BussinesEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ServicioBLL
    {
        public static string insertar(Servicio s)
        {
            string mensaje = "";
            //validar que no hay campos vacios
            if (
                   string.IsNullOrEmpty(s.Id.ToString())
                || string.IsNullOrEmpty(s.PacienteId.ToString())
                || string.IsNullOrEmpty(s.MedicoCanId.ToString())
                || string.IsNullOrEmpty(s.MedicoRF02Id.ToString())
                || string.IsNullOrEmpty(s.Pagado.ToString())
                || string.IsNullOrEmpty(s.Fecha_hora.ToString())
                || string.IsNullOrEmpty(s.Estado.ToString())
                || string.IsNullOrEmpty(s.Estudio.ToString())


              )
            {

                mensaje = "Favor de completar el formulario o usar el formato correcto";
            }
            else
            {

                //validar que el medico no se repita
                bool isExist = DataAccessLayer.ServicioDAL.consultaPorId(s.Id);
                if (isExist)
                {
                    mensaje = "Servicio ya registrado";
                }
                else
                {
                    bool isInserted = DataAccessLayer.ServicioDAL.insertar(s);
                    if (isInserted)
                    {
                        mensaje = "";

                    }
                    else
                    {
                        mensaje = "Error de insercion";
                    }

                }

            }
            return mensaje;
        }

        public static List<Servicio> busquedaIdMedCan(int id)
        {
            return DataAccessLayer.ServicioDAL.consultaPorIdMedCan(id);


        }

        public static List<Servicio> busquedaIdPac(int id)
        {
            return DataAccessLayer.ServicioDAL.consultaPorIdPac(id);


        }

        public static List<Servicio> visualizarnopagados(bool nopag)
        {
            return DataAccessLayer.ServicioDAL.consultaPorNopagados(nopag);
        }

        public static List<Servicio> consulta() {
            return DataAccessLayer.ServicioDAL.consulta();
        }

    }
}
