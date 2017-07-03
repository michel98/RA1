using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesEntities
{
    public class EstudiosRF01
    {

        private string Nombre { get; set; }
        private string Descripcion { get; set; }
        private string Categoría { get; set; }
        private double Costo { get; set; }
        private bool Estado { get; set; }


        public EstudiosRF01(string nombre,string descripcion,string categoria,double costo,bool estado)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Categoría = categoria;
            Costo = costo;
            Estado = estado;
        }

       


    }




}
