using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using System.Data;
using OFICINA.DTO;

namespace OFICINA.BLL
{
    public class FuncionarioBLL
    {
        private readonly DALProjeto dao;
        public FuncionarioBLL()
        {
            dao = new DALProjeto("localhost", "oficina", "root", "");
        }
        public DataTable ListarTodosFuncionarios()
        {
            try
            {
                return dao.SelectAll("funcionario");
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void CadastrarFuncionario(Funcionario funcionario)
        {
            try
            {
                dao.Insert("funcionario", funcionario);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AlterarDadosFuncionario(Funcionario funcionario)
        {
            try
            {
                dao.Update("funcionario", funcionario, 0);
            }
            catch (Exception)
            {
                throw;
            }

        }
        public void ExcluirFuncionario(Cliente funcionario)
        {
            try
            {
                dao.Delete("funcionario", funcionario, 0);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}