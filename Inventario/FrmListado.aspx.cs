using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using Common;


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
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["cadConexAccess"].ConnectionString;
            var vSql = "SELECT Nombre, Tipo, Categoria, Cantidad, FechaVencimiento, FechaRegistro FROM Producto";

            List<IngresoProductoComun> inventario = new List<IngresoProductoComun>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(vSql, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        IngresoProductoComun item = new IngresoProductoComun
                        {
                            Nombre = reader["Nombre"].ToString(),
                           // IdTipo = reader["Tipo"].ToString(),
                           // IdCategoria = reader["Categoria"].ToString(),
                            Cantidad = Convert.ToInt32(reader["Cantidad"]),
                            FechaVencimiento = Convert.ToDateTime(reader["FechaVencimiento"]),
                            FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"])
                        };

                        inventario.Add(item);
                    }

                    reader.Close();
                }

                GridView1.DataSource = inventario;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No hay productos" + ex.Message);
            }


        }

       
    }
}
