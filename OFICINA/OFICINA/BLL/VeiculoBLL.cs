using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using System.Data;
using OFICINA.DTO;

namespace OFICINA.BLL
{
    public class VeiculoBLL
    {
        private readonly DALProjeto dao;
        public VeiculoBLL()
        {
            dao = new DALProjeto("localhost", "oficina", "root", "");
        }
        public DataTable ListarTodosVeiculos()
        {
            try
            {
                return dao.SelectAll("veiculo");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void CadastrarVeiculo(Veiculo veiculo)
        {
            try
            {
                dao.Insert("veiculo", veiculo);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AlterarDadosVeiculo(Veiculo veiculo)
        {
            try
            {
                dao.Update("veiculo", veiculo, 0);
            }
            catch (Exception)
            {
                throw;
            }

        }
        public void ExcluirVeiculo(Veiculo veiculo)
        {
            try
            {
                dao.Delete("veiculo", veiculo, 0);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}