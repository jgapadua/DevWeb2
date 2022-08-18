using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class ContratoBLL
    {
        private readonly DALProjeto dao;
        public ContratoBLL()
        {
            dao = new DALProjeto("localhost", "bd_estacionamento", "root", "");
        }
        public DataTable ListarTodosContratos()
        {
            try
            {
                return dao.SelectAll("TBL_Contrato");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void CadastrarDadosContrato(Contrato contrato)
        {
            try
            {
                dao.Insert("TBL_Contrato", contrato);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Contrato ListarContratosmaiores100(Contrato contrato)
        {
            try
            {
                DataTable dt = dao.SelectWhere("TBL_Contrato", $"valor = '{contrato.Valor}'");
                if (contrato.Valor >= 100.00)


                {
                    contrato.IdCliente = Convert.ToInt32(dt.Rows[0][0]);
                    contrato.IdTipoContrato = Convert.ToInt32(dt.Rows[0][1]);
                    contrato.Valor = Convert.ToDouble (dt.Rows[0][2]);
                    
                    return contrato;
                }
                else
                    return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
       




    }
}