using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using AccesoADatos;
using System.Web.UI.WebControls;

namespace ReglaDeNegocio
{
    public class TipoProductoBL
    {
        public static void CargarCombo(DropDownList cmb)
        {
            TipoProductoDAO tipoProductosDAO = new TipoProductoDAO();
            List<TipoProducto> tipoProductos = tipoProductosDAO.CargarCombos();
            cmb.DataSource = tipoProductos;
            cmb.DataValueField = "Id";
            cmb.DataTextField = "Nombre";
            cmb.DataBind();
            cmb.SelectedIndex = 0;
        }
    }
}
