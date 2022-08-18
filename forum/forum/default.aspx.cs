using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DTO;

namespace forum
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["login"]!=null)
            {
                Membro membro = (Membro)Session["login"];
                Label1.Text = "Bem Vindo Sr(a) " + membro.NickMembro;
            }
            gviewPerguntas.DataSource = new PerguntaBLL().ListarTodosPerguntas();
            gviewPerguntas.DataBind();

        }
    }
}