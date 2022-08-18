using Agenciaturismo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agenciaturismo
{
    public partial class cadRestaurante : System.Web.UI.Page
    {
        Classes.Restaurante rest = new Classes.Restaurante();
        Classes.Hotel hot = new Classes.Hotel();
        Classes.Cidade cid = new Classes.Cidade();

        private void carregar_Grids()
        {
            GridView1.DataSource = rest.Listar_restaurantes();
            GridView1.DataBind();
            ddlCidade.DataSource = cid.Listar_cidades();
            ddlCidade.DataValueField = "idCidade";
            ddlCidade.DataTextField = "nomeCidade";
            ddlCidade.DataBind();
            ddlHotel.DataSource = hot.Listar_hoteis();
            ddlHotel.DataValueField = "idHotel";
            ddlHotel.DataTextField = "nomeHotel";
            ddlHotel.DataBind();
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
            rest.Nome = txtnome.Text;
            rest.Cep = Convert.ToInt32(txtcep.Text);
            rest.Num = Convert.ToInt32(txtnum.Text);
            rest.Complemento = txtcomple.Text;
            rest.Categoria = Convert.ToInt32(ddlCategoria.SelectedValue);
            rest.Cidade.Id = Convert.ToInt32(ddlCidade.SelectedValue);
            rest.Hotel.Id = Convert.ToInt32(ddlHotel.SelectedValue);

            rest.Cadastrar_restaurante();

            GridView1.DataSource = rest.Listar_restaurantes();
            GridView1.DataBind();
        }

        protected void btnlist_Click(object sender, EventArgs e)
        {
            carregar_Grids();
        }

        protected void btnremove_Click(object sender, EventArgs e)
        {
            rest.Id = Convert.ToInt32(txtid.Text);
           rest.Remover_restaurante();

            GridView1.DataSource = rest.Listar_restaurantes();
            GridView1.DataBind();
        }






    }
}