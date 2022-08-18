using Agenciaturismo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agenciaturismo
{
    public partial class cadMuseu : System.Web.UI.Page
    {
        Classes.Museu mus = new Museu();
        Classes.Cidade cid = new Cidade();

        private void carregar_Grids()
        {
            GridView1.DataSource = mus.Listar_museu();
            GridView1.DataBind();
            ddlCidade.DataSource = cid.Listar_cidades();
            ddlCidade.DataValueField = "idCidade";
            ddlCidade.DataTextField = "nomeCidade";
            ddlCidade.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                carregar_Grids();
            }

        }

        protected void btncad_Click(object sender, EventArgs e)
        {
            mus.Descricao = txtdescricao.Text;
            mus.Cep = Convert.ToInt32(txtcep.Text);
            mus.Num = Convert.ToInt32(txtnum.Text);
            mus.Complemento = txtcomple.Text;
            mus.Data =Convert.ToDateTime(txtdata.Text);
            mus.Salas =Convert.ToInt32(txtsala.Text);
            mus.Cidade.Id= Convert.ToInt32(ddlCidade.SelectedValue);
            mus.Cadastrar_museu();

            GridView1.DataSource = mus.Listar_museu();
            GridView1.DataBind();
        }

        protected void btnlist_Click(object sender, EventArgs e)
        {
            carregar_Grids();
        }

        protected void btnremove_Click(object sender, EventArgs e)
        {
            mus.Id = Convert.ToInt32(txtid.Text);
            mus.Remover_museu();

            GridView1.DataSource = mus.Listar_museu();
            GridView1.DataBind();
        }






    }
}