using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OFICINA.FORM
{
    public partial class CadastroFuncionario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnConsulta_Click(object sender, EventArgs e)
        {
            var ws = new WSCorreios.AtendeClienteClient();
            var resposta = ws.consultaCEP(txtcep.Text);
            txtendereco.Text = resposta.end;
            txtbairro.Text = resposta.bairro;
            txtuf.Text = resposta.uf;
            txtcidade.Text = resposta.cidade;

        }
    }
}