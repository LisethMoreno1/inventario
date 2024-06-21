using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class IngresoProductoComun
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public int IdTipo { get; set; }
        public int IdCategoria { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaRegistro { get; set; }

        public IngresoProductoComun()
        {
            IdProducto = 0;
            Nombre = string.Empty;
            IdTipo = 0;
            IdCategoria = 0;
            Cantidad = 0;
            FechaVencimiento = DateTime.MinValue;
            FechaRegistro = DateTime.Now;
        }

        public IngresoProductoComun(int idProducto, string nombre, int idTipo, int idCategoria, int cantidad, DateTime fechaVencimiento, DateTime fechaRegistro)
        {
            IdProducto = idProducto;
            Nombre = nombre;
            IdTipo = idTipo;
            IdCategoria = idCategoria;
            Cantidad = cantidad;
            FechaVencimiento = fechaVencimiento;
            FechaRegistro = fechaRegistro;
        }
    }
}
