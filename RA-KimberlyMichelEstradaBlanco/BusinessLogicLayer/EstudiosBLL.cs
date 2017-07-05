using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BussinesEntities;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class EstudiosBLL
    {
        List<EstudiosRF01> nueva = new List<EstudiosRF01>();
        public void agregar(EstudiosRF01 p) {
            nueva.Add(p);


        }
        public string combo() {
            string valor="";
            for (int i = 0; i < nueva.Count; i++) {
                valor = nueva[i].Id;
            }
            return valor; 
        }
    }
}
