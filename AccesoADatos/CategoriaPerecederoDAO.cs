using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.Data;
namespace AccesoADatos
{
    public class CategoriaPerecederoDAO
    {
        public List<CategoriaPerecedero> CargarCombo()
        {
            List<CategoriaPerecedero> categoriasPerecedero = new List<CategoriaPerecedero>();
            Data data = new Data();
            string vSql = "SELECT [Id], [Nombre] from CategoriaPerecedero";
            DataTable dt = data.CargarDt(vSql, CommandType.Text);
            foreach (DataRow fila in dt.Rows)
            {
                CategoriaPerecedero categoriaPerecedero = new CategoriaPerecedero
                {
                    Id = Convert.ToInt32(fila["Id"]),
                    Nombre = Convert.ToString(fila["Nombre"])
                };
                categoriasPerecedero.Add(categoriaPerecedero);
            };

            return categoriasPerecedero;
        }
    }
}
