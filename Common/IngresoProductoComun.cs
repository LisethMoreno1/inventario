using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class IngresoProductoComun
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Categoria { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaRegistro { get; set; }

        public IngresoProductoComun()
        {
            
            Nombre = string.Empty;
            Tipo = string.Empty;
            Categoria = string.Empty;
            Cantidad = 0;
            FechaVencimiento = DateTime.MinValue;
            FechaRegistro = DateTime.Now;
        }

        public IngresoProductoComun(string nombre, string tipo, string categoria, int cantidad, DateTime fechaVencimiento, DateTime fechaRegistro)
        {
            Nombre = nombre;
            Tipo = tipo;
            Categoria = categoria;
            Cantidad = cantidad;
            FechaVencimiento = fechaVencimiento;
            FechaRegistro = fechaRegistro;
        }
    }
}
