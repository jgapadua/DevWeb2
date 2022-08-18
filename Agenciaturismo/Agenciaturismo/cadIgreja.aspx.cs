using Agenciaturismo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agenciaturismo
{
    public partial class cadIgreja : System.Web.UI.Page
    {
        Classes.Igreja igr = new Igreja();
        Classes.Cidade cid = new Cidade();

        private void carregar_Grids()
        {
            GridView1.DataSource = igr.Listar_igreja();
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
            igr.Descricao = txtdescricao.Text;
            igr.Cep = Convert.ToInt32(txtcep.Text);
            igr.Num = Convert.ToInt32(txtnum.Text);
            igr.Complemento = txtcomple.Text;
            igr.Data = Convert.ToDateTime(txtdata.Text);
            igr.Estilo = ddlEstilo.SelectedValue;
            igr.Cidade.Id = Convert.ToInt32(ddlCidade.SelectedValue);
            igr.Cadastrar_igreja();

            GridView1.DataSource = igr.Listar_igreja();
            GridView1.DataBind();
        }

        protected void btnlist_Click(object sender, EventArgs e)
        {
            carregar_Grids();
        }

        protected void btnremove_Click(object sender, EventArgs e)
        {
            igr.Id = Convert.ToInt32(txtid.Text);
            igr.Remover_igreja();

            GridView1.DataSource = igr.Listar_igreja();
            GridView1.DataBind();
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = new Igreja().Listar_igreja();
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = new Igreja().Listar_igreja();
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Igreja igr = new Igreja();
            igr.Id = Convert.ToInt32(e.Values[0]);
            igr.Remover_igreja();
            GridView1.DataSource = igr.Listar_igreja();
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Igreja igr = new Igreja();
            igr.Id = Convert.ToInt32(e.NewValues[0]);
            igr.Descricao = e.NewValues[1].ToString();
            igr.Cep = Convert.ToInt32(e.NewValues[2]);
            igr.Num = Convert.ToInt32(e.NewValues[3]);
            igr.Complemento = e.NewValues[4].ToString();
            igr.Data = Convert.ToDateTime(e.NewValues[5]);
            igr.Estilo = e.NewValues[6].ToString();
            igr.Cidade.Id = Convert.ToInt32(e.NewValues[7]);
            igr.AlterarDadosIgreja();
            GridView1.EditIndex = -1;
            GridView1.DataSource = igr.Listar_igreja();
            GridView1.DataBind();
        }
    }
}







