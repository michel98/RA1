using System;
using System.Collections.Generic;
using System.Linq;
using BussinesEntities;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class MedicoCanalizadorBLL
    {
        public static string insertar(MedicoCanalizador m)
        {
            string mensaje = "";
            //validar que no hay campos vacios
            if (
                    string.IsNullOrEmpty(m.Id.ToString())
                || string.IsNullOrEmpty(m.Nombre)
                || string.IsNullOrEmpty(m.Apellidos)
             
                || string.IsNullOrEmpty(m.Cedula_profesional)
              )
            {

                mensaje = "Favor de completar el formulario o usar el formato correcto";
            }
            else
            {

                //validar que el medico no se repita
                bool isExist = DataAccessLayer.MedicoCanalizadorDAL.consultaPorIdBool(m.Id);
                if (isExist)
                {
                    mensaje = "Medico canalizador ya registrado";
                }
                else
                {
                    bool isInserted = DataAccessLayer.MedicoCanalizadorDAL.insertar(m);
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
        public static List<MedicoCanalizador> busquedaNombre(string nom)
        {
            return DataAccessLayer.MedicoCanalizadorDAL.consultaPorNombre(nom);


        }

        public static List<MedicoCanalizador> visualizar()
        {
            return DataAccessLayer.MedicoCanalizadorDAL.consulta();
        }

        public static List<MedicoCanalizador> busquedaId(int idmed)
        {
            return DataAccessLayer.MedicoCanalizadorDAL.consultaPorId(idmed);


        }


    }
}
