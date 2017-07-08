using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesEntities;

namespace BusinessLogicLayer
{
    public class MedicoBLL
    {

        
        //ahora regresara un mensaje
        public static string insertar(MedicoRF02 m)
        {
            string mensaje = "";
            //validar que no hay campos vacios
            if (
                string.IsNullOrEmpty(m.Nombre)
                || string.IsNullOrEmpty(m.Apellidos)
                || string.IsNullOrEmpty(m.Area)
                || string.IsNullOrEmpty(m.Esp_O_Cargo)
                || string.IsNullOrEmpty(m.Cedula_Profesional)
              )
            {

                mensaje = "Favor de completar el formulario o usar el formato correcto";
            }
            else
            {

                //validar que el medico no se repita
                bool isExist = DataAccessLayer.MedicoDAL.consultaPorCedula(m.Cedula_Profesional);
                if (isExist)
                {
                    mensaje = "Medico ya registrado";
                }
                else {
                    bool isInserted = DataAccessLayer.MedicoDAL.insertar(m);
                    if (isInserted)
                    {
                        mensaje = "";

                    }
                    else {
                        mensaje = "Error de insercion";
                    }

                }
               
            }
            return mensaje;
        }

        public static string actualizar(MedicoRF02 m) {
            string mensaje = "";
            if (
                string.IsNullOrEmpty(m.Nombre)
                || string.IsNullOrEmpty(m.Apellidos)
                || string.IsNullOrEmpty(m.Area)
                || string.IsNullOrEmpty(m.Esp_O_Cargo)
                || string.IsNullOrEmpty(m.Cedula_Profesional)
              )
            {

                mensaje = "Favor de completar el formulario o usar el formato correcto";
            }
            else
            {

                bool isUpdated = DataAccessLayer.MedicoDAL.actualizar(m);
                if (isUpdated)
                {
                    mensaje = "actualizado correctamente";
                }
                else {
                    mensaje = "Error de actualizacion";
                }
                
            }
            return mensaje;
        }

        public static List<MedicoRF02> visualizar() {
            return DataAccessLayer.MedicoDAL.consulta();
        }

        public static List<MedicoRF02> busquedaId(int idmedico) {
            return DataAccessLayer.MedicoDAL.consultaPorId(idmedico);
         

        }
        
        
        
        
    }

}
