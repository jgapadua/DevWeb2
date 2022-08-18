using Agenciaturismo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Agenciaturismo
{
    public partial class cadCidade : System.Web.UI.Page
    {
        Classes.Cidade cid = new Classes.Cidade();
        private void carregar_Grids()
        {
            GridView1.DataSource = cid.Listar_cidades();
            GridView1.DataBind();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                carregar_Grids();
            }

        }

        protected void btnlist_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = cid.Listar_cidades();
            GridView1.DataBind();
        }

        protected void btncad_Click(object sender, EventArgs e)
        {


            cid.Nome = txtnome.Text;
            cid.Uf = txtuf.Text;
            cid.Populacao = Convert.ToInt32(txtpop.Text);
            cid.Cadastrar_cidade();

            GridView1.DataSource = cid.Listar_cidades();
            GridView1.DataBind();
        }

        protected void btnremove_Click(object sender, EventArgs e)
        {
            cid.Id = Convert.ToInt32(txtid.Text);
            cid.Remover_cidade();

            GridView1.DataSource = cid.Listar_cidades();
            GridView1.DataBind();
        }

        protected void btnpesquisa_Click(object sender, EventArgs e)
        {            
            cid.Pesquisar_cidade(txtnome.Text, txtuf.Text);
          
        }

        protected void btnlistUF_Click(object sender, EventArgs e)
        {
            cid.ListarCidadesPorUF();

            GridView1.DataSource = cid.ListarCidadesPorUF();
            GridView1.DataBind();
        }

        protected void btnvisu_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = cid.Visualizar_cidade(Convert.ToInt32(txtid.Text));
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Cidade cid = new Cidade();
            cid.Id = Convert.ToInt32(e.Values[0]);
            cid.Remover_cidade();
            GridView1.DataSource = cid.Listar_cidades();
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = new Cidade().Listar_cidades();
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = new Cidade().Listar_cidades();
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Cidade cid = new Cidade();
            cid.Id = Convert.ToInt32(e.NewValues[0]);
            cid.Nome = e.NewValues[1].ToString();
            cid.Uf = e.NewValues[2].ToString();
            cid.Populacao = Convert.ToInt32(e.NewValues[3]);
            cid.AlterarDadosCidade();
            GridView1.EditIndex = -1;
            GridView1.DataSource = cid.Listar_cidades();
            GridView1.DataBind();
        }
    }
}