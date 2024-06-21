using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

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
            var vSql = "INSERT INTO Producto([IdProducto],[Nombre],[IdTipo],[IdCategoria],[Cantidad],[FechaVencimiento],[FechaRegistro]) VALUES(?,?,?,?,?,?,?)";
            bd.CrearComando(vSql, CommandType.Text);
            bd.AsignarParametro("?", OleDbType.VarChar, producto.IdProducto);
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

        public int Actualizar(IngresoProductoComun producto)
        {
            int numReg = 0;
            var vSql = "UPDATE Producto SET [Nombre]=?,[IdTipo]=?,[IdCategoria]=?,[Cantidad]=?,[FechaVencimiento]=?,[FechaRegistro]=? WHERE [IdProducto]=?";
            bd.CrearComando(vSql, CommandType.Text);
            bd.AsignarParametro("?", OleDbType.VarChar, producto.Nombre);
            bd.AsignarParametro("?", OleDbType.VarChar, producto.IdTipo);
            bd.AsignarParametro("?", OleDbType.VarChar, producto.IdCategoria);
            bd.AsignarParametro("?", OleDbType.VarChar, producto.Cantidad);
            bd.AsignarParametro("?", OleDbType.VarChar, producto.FechaVencimiento);
            bd.AsignarParametro("?", OleDbType.VarChar, producto.FechaRegistro);
            bd.AsignarParametro("?", OleDbType.VarChar, producto.IdProducto);
            numReg = bd.EjecutarComando();
            bd.Desconectar();
            if (numReg <= 0)
            {
                if (bd.BdCodeError != 0)
                {
                    BdCodeError = bd.BdCodeError;
                    BdMsgError = bd.BdMsgError;
                }
            }
            return numReg;
        }

        public List<IngresoProductoComun> Consultar()
        {
            var vSql = "SELECT [IdProducto], [Nombre], [IdTipo], [IdCategoria], [Cantidad], [FechaVencimiento], [FechaRegistro] FROM Producto";
            bd.CrearComando(vSql, CommandType.Text);

            List<IngresoProductoComun> inventario = new List<IngresoProductoComun>();

            OleDbDataReader dr = bd.EjecutarConsultaReader();
            while (dr.Read())
            {
                IngresoProductoComun item = new IngresoProductoComun
                {
                    IdProducto = Convert.ToInt32(dr["IdProducto"]),
                    Nombre = dr["Nombre"].ToString(),
                    IdTipo = Convert.ToInt32(dr["IdTipo"]),
                    IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                    Cantidad = Convert.ToInt32(dr["Cantidad"]),
                    FechaVencimiento = dr["FechaVencimiento"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["FechaVencimiento"]),
                    FechaRegistro = dr["FechaRegistro"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["FechaRegistro"])
                };
                inventario.Add(item);
            }

            dr.Close();
            bd.Desconectar();
            return inventario;
        }

        public int Eliminar(int idProducto)
        {
            int numReg = 0;
            var vSql = "DELETE FROM Producto WHERE [IdProducto]=?";
            bd.CrearComando(vSql, CommandType.Text);
            bd.AsignarParametro("?", OleDbType.VarChar, idProducto);

            numReg = bd.EjecutarComando();
            bd.Desconectar();
            if (numReg <= 0)
            {
                if (bd.BdCodeError != 0)
                {
                    BdCodeError = bd.BdCodeError;
                    BdMsgError = bd.BdMsgError;
                }
            }
            return numReg;
        }
    }


}
