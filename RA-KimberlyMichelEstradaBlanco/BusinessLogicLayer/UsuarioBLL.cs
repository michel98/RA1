using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BussinesEntities;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class UsuarioBLL
    {
        public static List<Usuario> consultar()
        {
            return DataAccessLayer.UsuarioDAL.consulta();
        }

        public static string insertar(Usuario u)
        {
            string mensaje = "";
            //validar que no hay campos vacios
            if (
                string.IsNullOrEmpty(u.UserName)
                || string.IsNullOrEmpty(u.Passwd)
                || string.IsNullOrEmpty(u.Activo.ToString())


              )
            {

                mensaje = "Favor de completar el formulario o usar el formato correcto";
            }
            else
            {
                //validar que el medico no se repita

                bool isInserted = DataAccessLayer.UsuarioDAL.insertar(u);
                if (isInserted)
                {
                    mensaje = "";

                }
                else
                {
                    mensaje = "Error de insercion";
                }

            }
                return mensaje;
        }

    }

}
