using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BussinesEntities;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class EstudioBLL
    {

        public static string insertar(EstudioRF01 e)
        {
            string mensaje = "";
            //validar que no hay campos vacios
            if (
                string.IsNullOrEmpty(e.Nombre)
                || string.IsNullOrEmpty(e.Descripcion)
                || string.IsNullOrEmpty(e.Categoría)
                || string.IsNullOrEmpty(e.Costo.ToString())
                
              )
            {

                mensaje = "Favor de completar el formulario o usar el formato correcto";
            }
            else
            {

                //validar que el medico no se repita
                bool isExist = DataAccessLayer.EstudioDAL.consultaPorNombre(e.Nombre);
                if (isExist)
                {
                    mensaje = "Estudio ya registrado";
                }
                else
                {
                    bool isInserted = DataAccessLayer.EstudioDAL.insertar(e);
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

        public static string actualizar(EstudioRF01 e)
        {
            string mensaje = "";
            if (
                string.IsNullOrEmpty(e.Nombre)
                || string.IsNullOrEmpty(e.Descripcion)
                || string.IsNullOrEmpty(e.Categoría)
                || string.IsNullOrEmpty(e.Costo.ToString())
              )
            {

                mensaje = "Favor de completar el formulario o usar el formato correcto";
            }
            else
            {

                bool isUpdated = DataAccessLayer.EstudioDAL.actualizar(e);
                if (isUpdated)
                {
                    mensaje = "actualizado correctamente";
                }
                else
                {
                    mensaje = "Error de actualizacion";
                }

            }
            return mensaje;
        }

        public static List<EstudioRF01> visualizar()
        {
            return DataAccessLayer.EstudioDAL.consulta();
        }

        public static List<EstudioRF01> busquedaId(int idestudio)
        {
            return DataAccessLayer.EstudioDAL.consultaPorId(idestudio);


        }




    }
}
