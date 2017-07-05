using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesEntities
{
    public class Pacientes
    {
        private int ID { get; set; }
        private string Nombre { get; set; }
        private string Apellidos { get; set; }
        private int Edad { get; set; }
        private string Lugar_Residencia { get; set; }

        public Pacientes(int Id, string nombre, string apellidos, int edad, string lugar_residencia)
        {
            ID = Id;
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
            Lugar_Residencia = Lugar_Residencia;
        }
    }
}
