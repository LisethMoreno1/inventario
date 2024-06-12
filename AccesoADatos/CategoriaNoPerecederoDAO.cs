using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos
{
    public class CategoriaNoPerecederoDAO
    {
        public List<CategoriaNoPerecedero> CargarCombo()
        {
            List<CategoriaNoPerecedero> categoriasNoPerecedero = new List<CategoriaNoPerecedero>();
            Data data = new Data();
            string vSql = "SELECT [Id], [Nombre] from CategoriaNoPerecedero";
            DataTable dt = data.CargarDt(vSql, CommandType.Text);
            foreach (DataRow fila in dt.Rows)
            {
                CategoriaNoPerecedero categoriaNoPerecedero = new CategoriaNoPerecedero
                {
                    Id = Convert.ToInt32(fila["Id"]),
                    Nombre = Convert.ToString(fila["Nombre"])
                };
                categoriasNoPerecedero.Add(categoriaNoPerecedero);
            };

            return categoriasNoPerecedero;
        }
    }
}
