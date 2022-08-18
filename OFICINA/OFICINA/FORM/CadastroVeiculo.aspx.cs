using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OFICINA.DTO;
using OFICINA.BLL;

namespace OFICINA.FORM
{
    public partial class CadastroVeiculo : System.Web.UI.Page
    {
        Veiculo veiculo = new Veiculo();
       ClienteBLL cliente = new ClienteBLL();
        ModeloBLL modelo = new ModeloBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack== false)
            {
                PreencheDonos();
                PreencheModelos();
                ExibirGridVeiculos();
            }
        }

        public void PreencheDonos()
        {
            drpDono.DataSource = cliente.ListarTodosClientes();
            drpDono.DataTextField = "nome";
            drpDono.DataValueField = "id";
            drpDono.DataBind();
        }
        public void PreencheModelos()
        {
            drpModelo.DataSource = modelo.ListarTodosModelos();
            drpModelo.DataTextField = "nome";
            drpModelo.DataValueField = "id";
            drpModelo.DataBind();
        }
        public void ExibirGridVeiculos()
        {
            gviewVeiculos.DataSource = new VeiculoBLL().ListarTodosVeiculos();
            gviewVeiculos.DataBind();
        }
        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Veiculo veiculo = new Veiculo();
            veiculo.Placa = txtplaca.Text;
            veiculo.Ano = txtano.Text;
            veiculo.Cor = txtcor.Text;
            veiculo.Id_dono = drpDono.SelectedIndex;
            veiculo.Id_modelo = drpModelo.SelectedIndex;

            new VeiculoBLL().CadastrarVeiculo(veiculo);
            Response.Write("<script>alert('Novo veiculo cadastrado');</script>");
        }
       
    }
}