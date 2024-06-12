using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class CategoriaNoPerecedero
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public CategoriaNoPerecedero(int Id, string Nombre)
        {
            this.Id = Id;
            this.Nombre = Nombre;
        }

        public CategoriaNoPerecedero()
        {
            Id = 0;
            Nombre = "";
        }
    }
}
