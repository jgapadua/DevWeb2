using Agenciaturismo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agenciaturismo
{
    public partial class cadCasaShow : System.Web.UI.Page
    {
        Classes.CasaShow cshow = new CasaShow();
        Classes.Cidade cid = new Cidade();

        private void carregar_Grids()
        {
            GridView1.DataSource = cshow.Listar_casashow();
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
            cshow.Descricao = txtdescricao.Text;
            cshow.Cep = Convert.ToInt32(txtcep.Text);
            cshow.Num = Convert.ToInt32(txtnum.Text);
            cshow.Complemento = txtcomple.Text;
            cshow.Data = Convert.ToDateTime(txtdata.Text);
            cshow.Fechamento = Convert.ToInt32(txtfecha.Text);
            cshow.Cidade.Id = Convert.ToInt32(ddlCidade.SelectedValue);
            cshow.Cadastrar_casashow();

            GridView1.DataSource = cshow.Listar_casashow();
            GridView1.DataBind();
        }

        protected void btnlist_Click(object sender, EventArgs e)
        {
            carregar_Grids();
        }

        protected void btnremove_Click(object sender, EventArgs e)
        {
            cshow.Id = Convert.ToInt32(txtid.Text);
            cshow.Remover_casashow();

            GridView1.DataSource = cshow.Listar_casashow();
            GridView1.DataBind();
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = new CasaShow().Listar_casashow();
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = new CasaShow().Listar_casashow();
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            CasaShow cshow = new CasaShow();
            cshow.Id = Convert.ToInt32(e.Values[0]);
            cshow.Remover_casashow();
            GridView1.DataSource = cshow.Listar_casashow();
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            CasaShow cshow = new CasaShow();
            cshow.Id = Convert.ToInt32(e.NewValues[0]);
            cshow.Descricao = e.NewValues[1].ToString();
            cshow.Cep = Convert.ToInt32(e.NewValues[2]);
            cshow.Num = Convert.ToInt32(e.NewValues[3]);
            cshow.Complemento = e.NewValues[4].ToString();
            cshow.Data = Convert.ToDateTime(e.NewValues[5]);
            cshow.Fechamento = Convert.ToInt32(e.NewValues[6]);
            cshow.Cidade.Id = Convert.ToInt32(e.NewValues[7]);
            cshow.AlterarDadosCasaShow();
            GridView1.EditIndex = -1;
            GridView1.DataSource = cshow.Listar_casashow();
            GridView1.DataBind();
        }





    }
}