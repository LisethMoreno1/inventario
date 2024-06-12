using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using AccesoADatos;

namespace ReglaDeNegocio
{
    public class RN_IngresoDeProductos
    {
        ProductoDAO productoDAO;
        public int BdCodeError { get; set; }
        public string BdMsgError { get; set; }

        public RN_IngresoDeProductos()
        {
            BdCodeError = 0;
            BdMsgError = string.Empty;
            productoDAO = new ProductoDAO();
        }

        public int RegistrarProducto(IngresoProductoComun producto)
        {

            //if (producto == null || string.IsNullOrEmpty(producto.Nombre) || producto.IdTipo <=0 || producto.IdCategoria <=0 || producto.Cantidad <= 0 || producto.FechaVencimiento == DateTime.MinValue || producto.FechaRegistro == DateTime.MinValue)
            //{
            //    return false; 
            //}
            //return true;

            var numReg = 0;
            numReg = productoDAO.Registrar(producto);
            if(numReg <= 0)
            {
                if(productoDAO.BdCodeError != 0)
                {
                    BdCodeError = productoDAO.BdCodeError;
                    BdMsgError = productoDAO.BdMsgError;
                }
            }
            return numReg;
        }
    }
}
