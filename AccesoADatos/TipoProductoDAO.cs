using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace AccesoADatos
{
    public class TipoProductoDAO
    {
        public List<TipoProducto> CargarCombos()
        {
            List<TipoProducto> tipoProductos = new List<TipoProducto>();
            Data data = new Data();
            string vSql = "SELECT [Id], [Nombre] from TipoProducto";
            DataTable dt = data.CargarDt(vSql, CommandType.Text);
            foreach (DataRow fila in dt.Rows)
            {
                TipoProducto tipoProducto = new TipoProducto
                {
                    Id = Convert.ToInt32(fila["Id"]),
                    Nombre = Convert.ToString(fila["Nombre"])
                };
                tipoProductos.Add(tipoProducto);

            }
            return tipoProductos;
        }
    }
}
