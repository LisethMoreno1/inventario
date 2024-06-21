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

        public int Actualizar(IngresoProductoComun producto)
        {
            var numReg = 0;
            numReg = productoDAO.Actualizar(producto);
            if (numReg <= 0)
            {
                if (productoDAO.BdCodeError != 0)
                {
                    BdCodeError = productoDAO.BdCodeError;
                    BdMsgError = productoDAO.BdMsgError;
                }
            }
            return numReg;
        }
        
        public static List<IngresoProductoComun> Consultar()
        {
            ProductoDAO productoDAO = new ProductoDAO();
            return productoDAO.Consultar();
        }

        public int Eliminar(int id)
        {
            var numReg = 0;
            numReg = productoDAO.Eliminar(id);
            if (numReg <= 0)
            {
                if (productoDAO.BdCodeError != 0)
                {
                    BdCodeError = productoDAO.BdCodeError;
                    BdMsgError = productoDAO.BdMsgError;
                }
            }
            return numReg;
        }

    }
}
