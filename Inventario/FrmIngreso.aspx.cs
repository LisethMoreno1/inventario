using Common;
using ReglaDeNegocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Web.Security;
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

        public static List<IngresoProductoComun> productosRegistrados = new List<IngresoProductoComun>();

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
                CalFechaVencimiento.Visible = true;
                LblNoAplica.Visible = false;
            }
            else
            {
                CategoriaNoPerecederoBL.CargarCombo(CmbCategoria);
                CalFechaVencimiento.Visible = false;
                LblNoAplica.Visible = true;
            }
        }


        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboCategoria();
        }

        private void Limpiar()
        {
            TxtId.Text = "";
            TxtNombre.Text = "";
            CmbTipoProducto.SelectedIndex = 0;
            CmbCategoria.SelectedIndex = 0;
            TxtCantidad.Text = "";
            CalFechaVencimiento.SelectedDate = DateTime.Today;
            CalFechaRegistro.SelectedDate = DateTime.Today; ;

        }

        protected void BtnRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                RN_IngresoDeProductos ingresoProductos = new RN_IngresoDeProductos();

                IngresoProductoComun productoComun = new IngresoProductoComun();

                productoComun.IdProducto = Convert.ToInt32(TxtId.Text);
                productoComun.Nombre = TxtNombre.Text;
                productoComun.IdTipo = Convert.ToInt32(CmbTipoProducto.Text);
                productoComun.IdCategoria = Convert.ToInt32(CmbCategoria.SelectedValue);
                productoComun.Cantidad = Convert.ToInt32(TxtCantidad.Text);
                if (CmbTipoProducto.SelectedItem.Text == "Perecedero")
                {
                    productoComun.FechaVencimiento = CalFechaVencimiento.SelectedDate;
                }
                else
                {
                    productoComun.FechaVencimiento = DateTime.MinValue;
                }
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
                        LblMensaje.Text = "No se insertó el producto";
                    }
                }
            }
            catch (FormatException ex)
            {
                LblMensaje.Text = "Formato de entrada inválido: " + ex.Message;
            }
            catch (SqlException ex)
            {
                LblMensaje.Text = "Error en la base de datos: " + ex.Message;
            }
            catch (Exception ex)
            {
                LblMensaje.Text = "Ocurrió un error: " + ex.Message;
            }
        }

    }
}
