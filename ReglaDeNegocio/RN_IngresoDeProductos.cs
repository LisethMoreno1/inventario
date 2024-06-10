using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace ReglaDeNegocio
{
    public class RN_IngresoDeProductos
    {
     
        public bool RegistrarProducto(IngresoProductoComun producto)
        {
            
            if (producto == null || string.IsNullOrEmpty(producto.Nombre) || string.IsNullOrEmpty(producto.Tipo) || string.IsNullOrEmpty(producto.Categoria) || producto.Cantidad <= 0 || producto.FechaVencimiento == DateTime.MinValue || producto.FechaRegistro == DateTime.MinValue)
            {
                return false; 
            }
            return true; 
        }
    }
}
