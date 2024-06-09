using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Categoria { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaRegistro { get; set; }

       
        public Producto()
        {
        }

       
        public Producto(int id, string nombre, string tipo, string categoria, int cantidad, DateTime fechaVencimiento, DateTime fechaRegistro)
        {
            Id = id;
            Nombre = nombre;
            Tipo = tipo;
            Categoria = categoria;
            Cantidad = cantidad;
            FechaVencimiento = fechaVencimiento;
            FechaRegistro = fechaRegistro;
        }
    }
}
