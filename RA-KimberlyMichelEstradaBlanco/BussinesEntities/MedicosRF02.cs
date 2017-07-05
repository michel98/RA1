using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesEntities
{
    public class MedicosRF02
    {
        private string IdMedico { get; set; }
        private string Nombre { get; set; }
        private string Apellidoos { get; set; }
        private string Area { get; set; }
        private string Esp_O_Cargo { get; set; }
        private string Ced_Profesional { get; set; }

        public MedicosRF02(string Id, string nombre, string apellidos, string area, string esp_o_cargo, string ced_profesional)
        {
            IdMedico = Id;
            Nombre = nombre;
            Apellidoos = apellidos;
            Area = area;
            Esp_O_Cargo = esp_o_cargo;
            Ced_Profesional = ced_profesional;
        }
    }
}
