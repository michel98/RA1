using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesEntities
{
    public class EstudiosRF01
    {

        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Categoría { get; set; }
        public double Costo { get; set; }
        public bool Estado { get; set; }


        public EstudiosRF01(string id, string nombre,string descripcion,string categoria,double costo,bool estado)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Categoría = categoria;
            Costo = costo;
            Estado = estado;
        }

       


    }




}
