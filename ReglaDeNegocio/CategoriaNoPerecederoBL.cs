using AccesoADatos;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace ReglaDeNegocio
{
    public class CategoriaNoPerecederoBL
    {
        public static void CargarCombo(DropDownList cmb)
        {
            CategoriaNoPerecederoDAO categoriaNoPerecederosDAO = new CategoriaNoPerecederoDAO();
            List<CategoriaNoPerecedero> categoriasNoPerecederos = categoriaNoPerecederosDAO.CargarCombo();
            cmb.DataSource = categoriasNoPerecederos;
            cmb.DataValueField = "Id";
            cmb.DataTextField = "Nombre";
            cmb.DataBind();
            cmb.SelectedIndex = 0;
        }
    }
}
