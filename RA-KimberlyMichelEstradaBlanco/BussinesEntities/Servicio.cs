using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesEntities
{
    public class Servicio
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public int MedicoCanId { get; set; }
        public int MedicoRF02Id { get; set; }
        public bool Estado { get; set; }
        public bool Pagado { get; set; }
        public string Diagnostico { get; set; }
        public DateTime Fecha_hora { get; set; }
        public string Estudio { get; set; }
    }
}
