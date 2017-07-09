using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesEntities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Passwd { get; set; }
        public bool Activo { get; set; }
    }
}
