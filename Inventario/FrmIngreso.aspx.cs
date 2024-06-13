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

            CmbTipoProducto.SelectedIndexChanged += new EventHandler(DropDownList1_SelectedIndexChanged);
            CmbTipoProducto.AutoPostBack = true;
        }

        private void CargarCombos()
        {
            CargarComboTipoProducto();
            CargarComboCategoria(); 
        }

        private void CargarComboTipoProducto()
        {
            TipoProductoBL.CargarCombo(CmbTipoProducto);
        }

        private void CargarComboCategoria()
        {
            if (CmbTipoProducto.SelectedItem != null && CmbTipoProducto.SelectedItem.Text == "Perecedero")
            {
                CategoriaPerecederoBL.CargarCombo(CmbCategoria);
            }
            else
            {
                CategoriaNoPerecederoBL.CargarCombo(CmbCategoria);
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboCategoria();
        }

        private void Limpiar()
        {
            TxtNombre.Text = "";
            CmbTipoProducto.SelectedIndex = 0;
            CmbCategoria.SelectedIndex = 0;
            TxtCantidad.Text = "";
            CalFechaVencimiento.SelectedDate = DateTime.Today;
            CalFechaRegistro.SelectedDate = DateTime.Today; ;

        }

        protected void BtnRegistro_Click(object sender, EventArgs e)
        {
            RN_IngresoDeProductos ingresoProductos = new RN_IngresoDeProductos();
            IngresoProductoComun productoComun = new IngresoProductoComun();
            productoComun.Nombre = TxtNombre.Text;
            productoComun.IdTipo = Convert.ToInt32(CmbTipoProducto.Text);
            productoComun.IdCategoria = Convert.ToInt32(CmbCategoria.Text);
            productoComun.Cantidad = Convert.ToInt32(TxtCantidad.Text);
            productoComun.FechaVencimiento = CalFechaVencimiento.SelectedDate;
            productoComun.FechaRegistro = CalFechaRegistro.SelectedDate;

            if (ingresoProductos.RegistrarProducto(productoComun) > 0)
            {
                LblMensaje.Text = "Se insertó el producto";
                Limpiar();
            }
            else
            {
                if (ingresoProductos.BdCodeError != 0)
                {
                    LblMensaje.Text = ingresoProductos.BdMsgError;
                }
                else
                {
                    LblMensaje.Text = "No se insertó el usuario";
                }
            }
            //string nombre = TextBox1.Text;
            //int tipo = Convert.ToInt32(DropDownList1.SelectedValue);
            //int categoria = Convert.ToInt32(DropDownList2.SelectedValue);
            //int cantidad = Convert.ToInt32(Request.Form["TextBox2"]);
            //DateTime fechaVencimiento = Calendar1.SelectedDate;
            //DateTime fechaRegistro = Calendar2.SelectedDate;

            //IngresoProductoComun nuevoProducto = new IngresoProductoComun(nombre, tipo, categoria, cantidad, fechaVencimiento, fechaRegistro);

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
