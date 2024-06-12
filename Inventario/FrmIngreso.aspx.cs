using Common;
using ReglaDeNegocio;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inventario
{
    public partial class FrmIngreso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarCombos();
            }

            DropDownList1.SelectedIndexChanged += new EventHandler(DropDownList1_SelectedIndexChanged);
            DropDownList1.AutoPostBack = true;
        }

        private void CargarCombos()
        {
            CargarComboTipoProducto();
            CargarComboCategoria(); 
        }

        private void CargarComboTipoProducto()
        {
            TipoProductoBL.CargarCombo(DropDownList1);
        }

        private void CargarComboCategoria()
        {
            if (DropDownList1.SelectedItem != null && DropDownList1.SelectedItem.Text == "Perecedero")
            {
                CategoriaPerecederoBL.CargarCombo(DropDownList2);
            }
            else
            {
                CategoriaNoPerecederoBL.CargarCombo(DropDownList2);
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboCategoria();
        }

        protected void BtnRegistro_Click(object sender, EventArgs e)
        {
            string nombre = TextBox1.Text;
            int tipo = Convert.ToInt32(DropDownList1.SelectedValue);
            int categoria = Convert.ToInt32(DropDownList2.SelectedValue);
            int cantidad = Convert.ToInt32(Request.Form["TextBox2"]);
            DateTime fechaVencimiento = Calendar1.SelectedDate;
            DateTime fechaRegistro = Calendar2.SelectedDate;

            IngresoProductoComun nuevoProducto = new IngresoProductoComun(nombre, tipo, categoria, cantidad, fechaVencimiento, fechaRegistro);

            // bool registroExitoso = gestorProductos.RegistrarProducto(nuevoProducto);

            // if (registroExitoso)
            // {
            //     Response.Write("<script>alert('Producto registrado ');</script>");
            // }
            // else
            // {
            //     Response.Write("<script>alert('Error al registrar el producto');</script>");
            // }
        }
    }
}
