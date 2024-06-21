using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.Web.UI.WebControls;
using Common;
using ReglaDeNegocio;

namespace Inventario
{
    public partial class FrmListado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarProductos();
            }
        }

        private void CargarProductos()
        {
            List<IngresoProductoComun> listaProductos = RN_IngresoDeProductos.Consultar();

            GridView1.DataSource = listaProductos;
            GridView1.DataBind();
        }


        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                IngresoProductoComun producto = (IngresoProductoComun)e.Row.DataItem;
                //Id
                TextBox txtIdProducto = (TextBox)e.Row.FindControl("TxtIdProducto");
                txtIdProducto.Text = producto.IdProducto.ToString();
                //Nombre
                TextBox txtIdNombre = (TextBox)e.Row.FindControl("TxtNombre");
                txtIdNombre.Text = producto.Nombre.ToString();
                //Tipo
                DropDownList cmbTipoProducto = (DropDownList)e.Row.FindControl("CmbTipoProducto");
                if (cmbTipoProducto != null)
                {
                    TipoProductoBL.CargarCombo(cmbTipoProducto);

                    cmbTipoProducto.SelectedValue = producto.IdTipo.ToString();
                }
                //Categoria
                DropDownList cmbCategoria = (DropDownList)e.Row.FindControl("CmbCategoria");
                if (cmbCategoria != null)
                {
                    if (cmbTipoProducto.SelectedItem != null && cmbTipoProducto.SelectedItem.Text == "Perecedero")
                    {
                        CategoriaPerecederoBL.CargarCombo(cmbCategoria);
                    }
                    else
                    {
                        CategoriaNoPerecederoBL.CargarCombo(cmbCategoria);
                    }

                    cmbCategoria.SelectedValue = producto.IdCategoria.ToString();
                }
                //Cantidad
                TextBox txtCantidad = (TextBox)e.Row.FindControl("TxtCantidad");
                txtCantidad.Text = producto.Cantidad.ToString();
                //fecha de vencimiento
                TextBox txtFechaVencimiento = (TextBox)e.Row.FindControl("TxtFechaVencimiento");

                if (producto.FechaVencimiento != new DateTime(2001, 1, 1))
                {
                    // Mostrar la fecha en el formato deseado
                    txtFechaVencimiento.Text = producto.FechaVencimiento.ToString("dd/MM/yyyy");
                }
                else
                {
                    txtFechaVencimiento.Text = "No Aplica";
                }
                //fecha de registro
                TextBox txtFechaRegistro = (TextBox)e.Row.FindControl("TxtFechaRegistro");
                txtFechaRegistro.Text = producto.FechaRegistro.ToString("dd/MM/yyyy");

            }
        }

        protected void BtnEditar_Click(object sender, EventArgs e)
        {
            RN_IngresoDeProductos ingresoBL = new RN_IngresoDeProductos();

            Button btnEditar = (Button)sender;
            GridViewRow row = (GridViewRow)btnEditar.NamingContainer;

            int idProducto = Convert.ToInt32(GridView1.DataKeys[row.RowIndex].Values["IdProducto"]);

            IngresoProductoComun productoComun = new IngresoProductoComun();
            productoComun.IdProducto = idProducto;

            TextBox txtNombre = (TextBox)row.FindControl("TxtNombre");
            DropDownList cmbTipoProducto = (DropDownList)row.FindControl("CmbTipoProducto");
            DropDownList cmbCategoria = (DropDownList)row.FindControl("CmbCategoria");
            TextBox txtCantidad = (TextBox)row.FindControl("TxtCantidad");
            TextBox txtFechaVencimiento = (TextBox)row.FindControl("TxtFechaVencimiento");
            TextBox txtFechaRegistro = (TextBox)row.FindControl("TxtFechaRegistro");

            //Nombre
            productoComun.Nombre = txtNombre.Text;
            //Tipo
            productoComun.IdTipo = Convert.ToInt32(cmbTipoProducto.SelectedValue);
            //Categoria
            productoComun.IdCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
            //Cantidad
            productoComun.Cantidad = Convert.ToInt32(txtCantidad.Text);

            // Fecha de vencimiento
            DateTime fechaVencimiento;
            if (DateTime.TryParseExact(txtFechaVencimiento.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaVencimiento))
            {
                productoComun.FechaVencimiento = fechaVencimiento;
            }

            //Fecha de registro
            DateTime fechaRegistro;
            if (DateTime.TryParseExact(txtFechaRegistro.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaRegistro))
            {
                productoComun.FechaRegistro = fechaRegistro;
            }

            if (ingresoBL.Actualizar(productoComun) > 0)
            {
                LblMensaje.Text = "Producto actualizado correctamente";
                CargarProductos();
            }
            else
            {
                LblMensaje.Text = "No se pudo actualizar el producto";
            }
        }


        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            RN_IngresoDeProductos ingresoBL = new RN_IngresoDeProductos();

            Button btn = (Button)sender;

            int idProducto = Convert.ToInt32(btn.CommandArgument);


            if (ingresoBL.Eliminar(idProducto) > 0)
            {
                LblMensaje.Text = "Producto eliminado correctamente";
                CargarProductos();
            }
            else
            {
                LblMensaje.Text = "No se pudo eliminar el producto";
            }
        }

        
    }
}
