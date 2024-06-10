using System;
using System.Web.UI.WebControls;
using Common;
using ReglaDeNegocio; 

namespace Inventario
{
    public partial class FrmLogin1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = TxtUsername.Text;
            string password = TxtPassword.Text;

            RN_Login negocioLogin = new RN_Login(); 

            if (negocioLogin.ValidateCredentials(username, password)) 
            {
                Response.Redirect("FrmIngreso.aspx");
            }
            else
            {
                LblMensaje.Text = "Usuario o contraseña invalidad";
                LblMensaje.CssClass = "message";
            }

           
            TxtUsername.Text = "";
            TxtPassword.Text = "";
        }

        protected void BtnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmIngreso.aspx");
        }

        
    }
}
