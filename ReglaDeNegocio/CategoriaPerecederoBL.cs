using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using Common;
using AccesoADatos;

namespace ReglaDeNegocio
{
    public class CategoriaPerecederoBL
    {
        public static void CargarCombo(DropDownList cmb)
        {
            CategoriaPerecederoDAO categoriaPerecederosDAO = new CategoriaPerecederoDAO();
            List<CategoriaPerecedero> categoriasPerecederos = categoriaPerecederosDAO.CargarCombo();
            cmb.DataSource = categoriasPerecederos;
            cmb.DataValueField = "Id";
            cmb.DataTextField = "Nombre";
            cmb.DataBind();
            cmb.SelectedIndex = 0;
        }
    }
}
