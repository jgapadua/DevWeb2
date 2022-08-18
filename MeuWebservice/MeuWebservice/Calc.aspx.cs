using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MeuWebservice
{
    public partial class Calc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSoma_Click(object sender, EventArgs e)
        {
            var ws = new Calc.WebService1SoapClient();
            var resposta = ws.Somar(Convert.ToInt32(valor1.Text), Convert.ToInt32(valor2.Text));
            resultado.Text = resposta.ToString();
        }

        protected void btnSubtrair_Click(object sender, EventArgs e)
        {
            var ws = new Calc.WebService1SoapClient();
            var resposta = ws.Subtrair(Convert.ToInt32(valor1.Text), Convert.ToInt32(valor2.Text));
            resultado.Text = resposta.ToString();
        }

        protected void btnMultiplicar_Click(object sender, EventArgs e)
        {
            var ws = new Calc.WebService1SoapClient();
            var resposta = ws.Multiplicar(Convert.ToInt32(valor1.Text), Convert.ToInt32(valor2.Text));
            resultado.Text = resposta.ToString();
        }

        protected void btnDividir_Click(object sender, EventArgs e)
        {
            var ws = new Calc.WebService1SoapClient();
            var resposta = ws.Dividir(Convert.ToInt32(valor1.Text), Convert.ToInt32(valor2.Text));
            resultado.Text = resposta.ToString();

        }
    }
}