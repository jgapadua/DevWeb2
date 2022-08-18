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
    public partial class registrese : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncad_Click(object sender,EventArgs e)
        {
            try
            {
                Membro membro = new Membro();
                membro.EmailMembro = txtemail.Text;
                membro.NickMembro = txtnick.Text;
                membro.NomeMembro = txtnome.Text;
                membro.SenhaMembro = txtsenha.Text;
                new MembroBLL().CadastrarDadosMembros(membro);
                Response.Write("<script>alert('Cadastro efetuado');</script>");
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}