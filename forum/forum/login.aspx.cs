using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BLL;

namespace forum
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Membro membro = new Membro();
            membro.EmailMembro = txtemail.Text;
            membro.SenhaMembro = txtsenha.Text;
            Session["login"] = new MembroBLL().AutenticarMembro(membro);
            if (Session["login"] != null)
                Response.Redirect("default.aspx");
            else
            {
                Response.Write("<script>alert('E-mail ou senha incorretos');</script>");
            }

        }
    }
}