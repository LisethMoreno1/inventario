using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace ReglaDeNegocio
{
    public class RN_Producto
    {
      
        public List<Producto> ObtenerListaInventario()
        {

            List<Producto> listaProductos = new List<Producto>
            {
                new Producto(1, "Producto 1", "Tipo 1", "Categoria 1", 10, DateTime.Now.AddMonths(1), DateTime.Now),
                new Producto(2, "Producto 2", "Tipo 2", "Categoria 2", 5, DateTime.Now.AddMonths(2), DateTime.Now.AddDays(-5)),
                new Producto(3, "Producto 3", "Tipo 1", "Categoria 3", 20, DateTime.Now.AddMonths(3), DateTime.Now.AddDays(-10))
            };

            return listaProductos;
        }

       
        public void AgregarProducto(Producto nuevoProducto)
        {
           
        }

    }
}
