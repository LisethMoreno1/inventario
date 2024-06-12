using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TipoProducto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public TipoProducto() 
        {
            Id = 0;
            Nombre = string.Empty;
        }

        public TipoProducto(int Id, string Nombre)
        {
            this.Id = Id;
            this.Nombre = Nombre;
        }
    }
}
