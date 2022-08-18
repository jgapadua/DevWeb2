using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MeuWebservice
{
    /// <summary>
    /// Descrição resumida de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod]
        public int Dividir(int numero1, int numero2)
        {
            return numero1 / numero2;
        }
        [WebMethod]
        public int Somar(int numero1, int numero2)
        {

            return numero1 + numero2;
        }

        [WebMethod]
        public int Multiplicar(int numero1, int numero2)
        {

            return numero1 * numero2;
        }

        [WebMethod]
        public int Subtrair(int numero1, int numero2)
        {
            if (numero1 < numero2)
            {
                return numero2 - numero1;
            }
            else
            {
                return numero1 - numero2;
            }
        }

    }
}
