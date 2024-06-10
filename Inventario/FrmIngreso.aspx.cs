using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common;
using ReglaDeNegocio;

namespace Inventario
{
    public partial class FrmIngreso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegistro_Click(object sender, EventArgs e)
        {
      
            string nombre = TextBox1.Text;
            string tipo = DropDownList1.SelectedValue;
            string categoria = DropDownList2.SelectedValue;
            int cantidad = Convert.ToInt32(Request.Form["TextBox2"]); 
            DateTime fechaVencimiento = Calendar1.SelectedDate;
            DateTime fechaRegistro = Calendar2.SelectedDate;

            IngresoProductoComun nuevoProducto = new IngresoProductoComun(nombre, tipo, categoria, cantidad, fechaVencimiento, fechaRegistro);

            bool registroExitoso = gestorProductos.RegistrarProducto(nuevoProducto);

            if (registroExitoso)
            {
            
                Response.Write("<script>alert('Producto registrado ');</script>");
            }
            else
            {
               
                Response.Write("<script>alert('Error al registrar el producto');</script>");
            }
        }
    }
}
}