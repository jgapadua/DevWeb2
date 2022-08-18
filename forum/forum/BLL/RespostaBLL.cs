using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class RespostaBLL
    {
        private readonly DALProjeto dao;
        public RespostaBLL()
        {
            dao = new DALProjeto("localhost", "stackoverflow", "root", "");
        }
        public DataTable ListarTodosRespostas()
        {
            try
            {
                return dao.SelectAll("resposta");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void CadastrarDadosRespostas(Respostas resposta)
        {
            try
            {
                dao.Insert("resposta", resposta);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AlterarDadosRespostas(Respostas resposta)
        {
            try
            {
                dao.Update("resposta", resposta, 0);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void ExcluirRespostas(Respostas resposta)
        {
            try
            {
                dao.Delete("resposta", resposta, 0);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}