using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;

namespace Inventario
{
    public partial class FrmMainAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LblBienvenida.Text = "Bienvenid@ " + Session["Nombre"];
        }
        protected void LkbCerrarSesion_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }
    }
}