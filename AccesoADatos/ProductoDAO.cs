using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.Data;
using System.Data.OleDb;

namespace AccesoADatos
{
    public class ProductoDAO
    {
        BaseDeDatos bd;
        public int BdCodeError { get; set; }
        public string BdMsgError { get; set; }
        public ProductoDAO()
        {
            BdCodeError = 0;
            BdMsgError = string.Empty;
            bd = new BaseDeDatos();
            bd.Conectar();
        }
        public int Registrar(IngresoProductoComun producto)
        {
            int numReg = 0;
            var vSql = "INSERT INTO Producto([Nombre],[IdTipo],[IdCategoria],[Cantidad],[FechaVencimiento],[FechaRegistro]) VALUES(?,?,?,?,?,?)";
            bd.CrearComando(vSql, CommandType.Text);
            bd.AsignarParametro("?", OleDbType.VarChar, producto.Nombre);
            bd.AsignarParametro("?", OleDbType.VarChar, producto.IdTipo);
            bd.AsignarParametro("?", OleDbType.VarChar, producto.IdCategoria);
            bd.AsignarParametro("?", OleDbType.VarChar, producto.Cantidad);
            bd.AsignarParametro("?", OleDbType.VarChar, producto.FechaVencimiento);
            bd.AsignarParametro("?", OleDbType.VarChar, producto.FechaRegistro);
            numReg = bd.EjecutarComando();
            bd.Desconectar();
            if(numReg <= 0)
            {
                if(bd.BdCodeError != 0)
                {
                    BdCodeError = bd.BdCodeError;
                    BdMsgError = bd.BdMsgError;
                }
            }
            return numReg;
        }
    }
}
