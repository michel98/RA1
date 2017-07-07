using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesEntities
{
    public class MedicoRF02
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Area { get; set; }
        public string Esp_O_Cargo { get; set; }
        public string Cedula_Profesional { get; set; }

        
    }
}
