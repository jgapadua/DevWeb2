using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bookonline.BLL;
using Bookonline.DTO;

namespace Bookonline.FORMS
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gviewLivros.DataSource = new LivroBLL().ListarTodosLivros();
            gviewLivros.DataBind();
        }
        protected void btnPesquisar_Click(object sender, EventArgs e)
        {

            string condicao = "titulo like '%" + Txttitulo.Text;      

            gviewLivros.DataSource = new LivroBLL().ConsultaLivro(condicao);
            gviewLivros.DataBind();
        }
    }
}