using Agenciaturismo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agenciaturismo
{
    public partial class cadHotel : System.Web.UI.Page
    {
        Classes.Hotel hot = new Hotel();
        Classes.Cidade cid = new Cidade();

        private void carregar_Grids()
        {
            GridView1.DataSource = hot.Listar_hoteis();
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
            hot.Nome = txtnome.Text;
            hot.Cep = Convert.ToInt32(txtcep.Text);
            hot.Num = Convert.ToInt32(txtnum.Text);
            hot.Complemento = txtcomple.Text;
            hot.Categoria = Convert.ToInt32(ddlCategoria.SelectedValue);
            hot.Cidade.Id = Convert.ToInt32(ddlCidade.SelectedValue);
            hot.Cadastrar_hotel();

            GridView1.DataSource = hot.Listar_hoteis();
            GridView1.DataBind();
        }

        protected void btnlist_Click(object sender, EventArgs e)
        {
            carregar_Grids();
        }

        protected void btnremove_Click(object sender, EventArgs e)
        {
            hot.Id = Convert.ToInt32(txtid.Text);
            hot.Remover_hotel();

            GridView1.DataSource = hot.Listar_hoteis();
            GridView1.DataBind();
        }






    }
}