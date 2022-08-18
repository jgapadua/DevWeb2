using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BLL;

namespace Prova3B18.FORM
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gviewcontratos.DataSource = new ContratoBLL().ListarTodosContratos();
            gviewcontratos.DataBind();
        }
        protected void btncadclientes_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.Nome = txtnome.Text;
                cliente.Endereco = txtendereco.Text;
                cliente.Telefone = txttelefone.Text;
                cliente.PlacaVeiculo = txtplaca.Text;
                new ClienteBLL().CadastrarDadosCliente(cliente);
                Response.Write("<script>alert('Cadastro efetuado');</script>");
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void btncadcontrato_Click(object sender, EventArgs e)
        {
            try
            {
                Contrato contrato = new Contrato();
                contrato.IdCliente = Convert.ToInt32(ddlcliente.SelectedValue);
                contrato.IdTipoContrato = Convert.ToInt32(ddltipocontrato.SelectedValue);
                contrato.Valor = Convert.ToDouble(txtvalor.Text);
                contrato.DataInicio = Convert.ToDateTime(txtdata.Text);
                contrato.NumeroVaga = Convert.ToInt32(txtnumerovagas.Text);           
                new ContratoBLL().CadastrarDadosContrato(contrato);
                Response.Write("<script>alert('Cadastro efetuado');</script>");
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void btnexibir_Click(object sender, EventArgs e)
        {
            gviewcontratos.DataSource = new ContratoBLL().ListarContratosmaiores100();
            gviewcontratos.DataBind();
        }
    }
}