using Municipios.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Municipios.DTO;

namespace Municipios.FORMS
{
    public partial class ConsultaMunicipio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gviewMunicipio.DataSource = new MunicipioBLL().ListarTodosMunicipios();
            gviewMunicipio.DataBind();
        }
        protected void btnPesquisar_Click(object sender, EventArgs e)
        {

            string condicao = "Nome like '%" + txtpesquisa.Text + "%' or Uf like '%" + txtpesquisa.Text +"%'";

            gviewMunicipio.DataSource = new MunicipioBLL().ConsultaMunicipio(condicao);
            gviewMunicipio.DataBind();
        }
    }
}